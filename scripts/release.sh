mkdir -p ./generated
./generate_version_tags.py

for f in *.json; do java -jar swagger-codegen-cli.jar generate -i http://127.0.0.1:9999/api/swagger.json -l ${f%.*} -o ../${f%.*}-client -c generated/$f ; done