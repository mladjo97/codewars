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
c_files  = ''

for dirpath, dirnames, filenames in os.walk(os.getcwd()):
    if '.git' in dirpath:
        continue

    for filename in filenames:
        if filename == 'generate_readme.py':
            continue
        
        if '.cs' in filename:
            cs_files += '* [' + filename + '](./c-sharp/' + filename + ')\n\n'
        elif '.js' in filename:
            js_files += '* [' + filename + '](./javascript/' + filename + ')\n\n'
        elif '.py' in filename:
            py_files += '* [' + filename + '](./python/' + filename + ')\n\n'
        elif '.c' in filename:
            c_files += '* [' + filename + '](./c/' + filename + ')\n\n'

table_of_content = '# Table of Content: \n\n'
table_of_content += '## C# solutions:\n' + cs_files + '\n'
table_of_content += '## JavaScript solutions:\n' + js_files + '\n'
table_of_content += '## Python solutions:\n' + py_files
table_of_content += '## C solutions:\n' + c_files

print('Writting to README.md file...')
readme_file = open(readme_filepath, 'w+')
readme_file.write(table_of_content)
readme_file.close()
print('Successfully generated README.md file.')