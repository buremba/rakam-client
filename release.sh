./generate_version_tags.py
rm -rf ./dist && mkdir -p ./dist && cd ./dist

for f in ../config/*.json; do java -jar ../swagger-codegen-cli-*.jar generate --git-user-id "rakam-io" --git-repo-id "rakam-$(basename ${f%.*})-client" --release-note "Initial commit" -i http://127.0.0.1:9998/api/swagger.json -l $(basename ${f%.*}) -o ./$(basename ${f%.*})-client -c $f ; done

for f in ./*; do cd $f; sh ./git_push.sh; done