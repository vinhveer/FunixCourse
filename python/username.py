import pandas as pd
import unicodedata
import re
from datetime import datetime
from collections import defaultdict

def convert_to_username(first_name, last_name, existing_usernames):
    """
    Convert Vietnamese name to username format and handle duplicates.
    Args:
        first_name: First/given name
        last_name: Last name/family name (including middle name)
    Returns:
        username: Generated unique username
    """
    def remove_accents(text):
        """Remove diacritics from Vietnamese text"""
        text = unicodedata.normalize('NFKD', text)
        text = ''.join([c for c in text if not unicodedata.combining(c)])
        return text
    
    def clean_text(text):
        """Clean text by removing special characters and converting to lowercase"""
        text = remove_accents(text)
        text = re.sub(r'[^a-zA-Z\s]', '', text)
        return text.lower()
    
    # Clean both names
    clean_first = clean_text(first_name)
    clean_last = clean_text(last_name)
    
    # Split last name into words and get initials
    last_name_words = clean_last.split()
    last_name_initials = ''.join([word[0] for word in last_name_words])
    
    # Create base username (first name + all initials from last name)
    base_username = clean_first + "." + last_name_initials 
    
    # Handle duplicates
    final_username = base_username
    if base_username in existing_usernames:
        count = existing_usernames[base_username]
        final_username = f"{base_username}{count}"
        existing_usernames[base_username] = count + 1
    else:
        existing_usernames[base_username] = 1
    
    return final_username

# Read the names and create usernames
names = []
usernames = []
username_counts = defaultdict(int)

with open('paste.txt', 'r', encoding='utf-8') as file:
    for line in file:
        first_name, last_name = line.strip().split('\t')
        username = convert_to_username(first_name, last_name, username_counts)
        names.append((first_name, last_name))
        usernames.append(username)

# Create a DataFrame
df = pd.DataFrame({
    'Tên': [name[0] for name in names],
    'Họ và tên đệm': [name[1] for name in names],
    'Username': usernames,
    'Email': [f'{username}@ntu.edu.vn' for username in usernames]
})

# Generate timestamp for unique filename
timestamp = datetime.now().strftime("%Y%m%d_%H%M%S")
filename = f'usernames_{timestamp}.xlsx'

# Export to Excel with custom formatting
with pd.ExcelWriter(filename, engine='xlsxwriter') as writer:
    df.to_excel(writer, sheet_name='Usernames', index=False)
    
    # Get workbook and worksheet objects
    workbook = writer.book
    worksheet = writer.sheets['Usernames']
    
    # Define formats
    header_format = workbook.add_format({
        'bold': True,
        'text_wrap': True,
        'valign': 'top',
        'fg_color': '#D7E4BC',
        'border': 1
    })
    
    # Set column widths
    worksheet.set_column('A:A', 15)  # Tên
    worksheet.set_column('B:B', 25)  # Họ và tên đệm
    worksheet.set_column('C:C', 15)  # Username
    worksheet.set_column('D:D', 30)  # Email
    
    # Apply header format
    for col_num, value in enumerate(df.columns.values):
        worksheet.write(0, col_num, value, header_format)

print(f"Excel file has been created: {filename}")
print(f"Total records processed: {len(df)}")

# Display first few examples
print("\nExample usernames:")
for i in range(min(5, len(df))):
    print(f"{df['Họ và tên đệm'][i]} {df['Tên'][i]} -> {df['Username'][i]}")