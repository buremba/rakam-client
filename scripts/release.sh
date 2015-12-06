mkdir -p ./generated
./generate_version_tags.py

for f in ./generated/*.json; do java -jar swagger-codegen-cli.jar generate -i http://127.0.0.1:9999/api/swagger.json -l $(basename ${f%.*}) -o ../$(basename ${f%.*})-client -c $f ; done