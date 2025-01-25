import pandas as pd
import pyodbc
from datetime import datetime

def create_connection():
    """Create database connection"""
    conn = pyodbc.connect('Driver={SQL Server};'
                         'Server=DESKTOP-QDP6VSH\VINHNQ;'
                         'Database=NTU_UMS;'
                         'Trusted_Connection=yes;')
    return conn

def clean_user_id(user_id):
    """Remove commas and spaces from User ID"""
    if isinstance(user_id, str):
        return user_id.replace(',', '').replace(' ', '')
    return str(user_id).replace(',', '').replace(' ', '')

def convert_date(date_str):
    """Convert date string to SQL Server format"""
    if pd.isna(date_str):
        return None
    
    try:
        # Convert DD/MM/YYYY to YYYY-MM-DD
        day, month, year = date_str.split('/')
        return f"{year}-{month.zfill(2)}-{day.zfill(2)}"
    except:
        return None

def insert_data(excel_file_path):
    # Current UTC time and user
    CURRENT_TIME = '2024-12-29 07:39:53'
    
    # Read Excel file
    try:
        df = pd.read_excel(excel_file_path)
        # Clean User ID column - remove commas and spaces
        df['User ID'] = df['User ID'].apply(clean_user_id)
        
        if df.empty:
            raise Exception("Excel file is empty")
    except Exception as e:
        print(f"Error reading Excel file: {str(e)}")
        return

    # Create database connection
    try:
        conn = create_connection()
        cursor = conn.cursor()
        
        # Start transaction
        conn.autocommit = False
        
        for index, row in df.iterrows():
            try:
                # Clean and convert data
                user_id = clean_user_id(row['User ID'])
                dob = convert_date(row['Date of Birth'])
                
                # 1. Insert into Users
                user_insert = """
                INSERT INTO [dbo].[Users] 
                ([user_id], [email], [password_hash], [user_type], [account_status], [created_at])
                VALUES (?, ?, ?, 2, 1, ?)
                """
                cursor.execute(user_insert, 
                             user_id,
                             row['Email'],
                             row['Password'],
                             CURRENT_TIME)

                # 2. Insert into Profiles
                profile_insert = """
                INSERT INTO [dbo].[Profiles]
                ([user_id], [first_name], [last_name], [date_of_birth], [gender], 
                 [phone_number], [address])
                VALUES (?, ?, ?, ?, ?, ?, ?)
                """
                cursor.execute(profile_insert,
                             user_id,
                             row['First Name'],
                             row['Last Name'],
                             dob,
                             row['Gender'] if pd.notna(row['Gender']) else None,
                             row['Phone Number'] if pd.notna(row['Phone Number']) else None,
                             row['Address'] if pd.notna(row['Address']) else None)

                # 3. Insert into Students
                student_insert = """
                INSERT INTO [dbo].[Students]
                ([user_id], [program_id], [entry_year])
                VALUES (?, ?, ?)
                """
                cursor.execute(student_insert,
                             user_id,
                             row['Program ID'],
                             2024)  # Current year

            except Exception as e:
                # If any error occurs during insertion, rollback the entire transaction
                conn.rollback()
                print(f"Error inserting data for User ID {user_id}: {str(e)}")
                print("Rolling back all changes...")
                return False

        # If all insertions are successful, commit the transaction
        conn.commit()
        print("All data inserted successfully!")
        return True

    except Exception as e:
        print(f"Database connection error: {str(e)}")
        return False

    finally:
        if 'conn' in locals():
            conn.close()

if __name__ == "__main__":
    try:
        excel_file_path = 'StudentTemplate_20241229 (1).xlsx'  # Replace with your Excel file path
        success = insert_data(excel_file_path)
        
        if success:
            print("Process completed successfully!")
        else:
            print("Process failed! No changes were made to the database.")
            
    except Exception as e:
        print(f"An unexpected error occurred: {str(e)}")