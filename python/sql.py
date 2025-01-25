import pandas as pd
from datetime import datetime

def generate_sql_inserts(excel_file_path):
    # Read Excel file
    df = pd.read_excel(excel_file_path)
    
    # Generate SQL INSERT statements
    sql_statements = []
    
    for index, row in df.iterrows():
        # Format date of birth
        dob = row['Date of Birth']
        if pd.notna(dob):
            if isinstance(dob, str):
                # Try to parse string date in common formats
                try:
                    dob = datetime.strptime(dob, '%Y-%m-%d').strftime('%Y-%m-%d')
                except ValueError:
                    try:
                        dob = datetime.strptime(dob, '%d/%m/%Y').strftime('%Y-%m-%d')
                    except ValueError:
                        dob = None
            else:
                # If it's already a datetime object
                dob = dob.strftime('%Y-%m-%d')
        else:
            dob = None

        # Prepare values with proper formatting
        values = {
            'user_id': str(row['User ID']),
            'first_name': row['First Name'],
            'last_name': row['Last Name'],
            'date_of_birth': f"'{dob}'" if dob else 'NULL',
            'gender': int(row['Gender (1=Nam, 0=Nữ)']) if pd.notna(row['Gender (1=Nam, 0=Nữ)']) else 'NULL',
            'phone_number': f"'{str(row['Phone Number'])}'" if pd.notna(row['Phone Number']) else 'NULL',
            'address': f"N'{str(row['Address'])}'" if pd.notna(row['Address']) else 'NULL',
            'avatar_path': 'NULL'  # Default value as per schema
        }
        
        # Generate INSERT statement
        sql = f"""INSERT INTO [dbo].[Profiles] 
                ([user_id], [first_name], [last_name], [date_of_birth], [gender], [phone_number], [address], [avatar_path])
                VALUES
                ('{values['user_id']}', N'{values['first_name']}', N'{values['last_name']}', 
                {values['date_of_birth']}, {values['gender']}, {values['phone_number']}, 
                {values['address']}, {values['avatar_path']});"""
        
        sql_statements.append(sql)
    
    return sql_statements

# Usage example
try:
    # Replace 'your_excel_file.xlsx' with your actual Excel file path
    excel_file_path = 'UserProfileTemplate - 28_12_2024 4_17_40 PM.xlsx'
    sql_statements = generate_sql_inserts(excel_file_path)
    
    # Write SQL statements to a file
    with open('profile_inserts.sql', 'w', encoding='utf-8') as f:
        f.write('USE [NTU_UMS]\nGO\n\n')
        for sql in sql_statements:
            f.write(sql + '\nGO\n\n')
    
    print("SQL insert statements have been generated successfully!")

except Exception as e:
    print(f"An error occurred: {str(e)}")