import os

readme_filepath = ('README.md')

try:
    print('Removing README.md ...')
    os.remove(readme_filepath)
    print("README.md removed. \n")
except:
    print('README.me was not found.\n')

# Generate Table of Content
cs_files = ''
js_files = ''
py_files = ''

for dirpath, dirnames, filenames in os.walk(os.getcwd()):
    if '.git' in dirpath:
        continue

    for filename in filenames:
        if filename == 'generate_readme.py':
            continue
        
        if '.cs' in filename:
            cs_files += '\t>> [./c-sharp/' + filename + ']' + filename + '\n'
        if '.js' in filename:
            js_files += '\t>> [./javascript/' + filename + ']' + filename + '\n'
        if '.py' in filename:
            py_files += '\t>> [./python/' + filename + ']' + filename + '\n'

table_of_content = '# Table of Content: \n\n'
table_of_content += '## C# solution:\n' + cs_files + '\n'
table_of_content += '## JavaScript solution:\n' + js_files + '\n'
table_of_content += '## Python solutions:\n' + py_files

print(table_of_content)

print('Writting to README.md file...')
readme_file = open(readme_filepath, 'w+')
readme_file.write(table_of_content)
readme_file.close()
print('Successfully generated README.md file.')