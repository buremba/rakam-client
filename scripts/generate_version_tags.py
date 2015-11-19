#!/usr/local/bin/python
import requests
import json, os

swagger = requests.get("http://127.0.0.1:9999/api/swagger.json").json()
output_dir = 'output/'

files = [f for f in os.listdir('.') if os.path.isfile(f) and os.path.splitext(f)[1] == '.json']
for config_file in files:
    options = json.loads(open(config_file).read())
    for option in options:
        if options[option] is None:
            options[option] = swagger.get('info').get('version')
    output = open("generated/"+config_file, "w")
    output.write(json.dumps(options))
    output.close()