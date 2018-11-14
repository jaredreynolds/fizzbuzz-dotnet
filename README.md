```
dotnet publish -c Release -o dist
docker build -t fizzbuzz .
docker run -it --rm --name fizzbuzz fizzbuzz
```
