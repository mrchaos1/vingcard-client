up: build run

build:
	csc -platform:x86 src/*.cs -out:build/client.exe

run:
	 mono ./build/client.exe
