up: build run

build:
	csc -platform:x86 *.cs -out:bin/client.exe

run:
	 mono ./bin/client.exe
