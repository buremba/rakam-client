#!/usr/local/bin/python
import requests
import json, os

swagger = requests.get("http://127.0.0.1:9998/api/swagger.json").json()
output_dir = 'config/'
input_dir = './config_template/'

files = [f for f in os.listdir(input_dir) if os.path.isfile(input_dir+f) and os.path.splitext(f)[1] == '.json']
for config_file in files:
    options = json.loads(open(input_dir+config_file).read())
    for option in options:
        if options[option] is None:
            options[option] = swagger.get('info').get('version')
    output = open(output_dir+config_file, "w")
    output.write(json.dumps(options))
    output.close()
print files