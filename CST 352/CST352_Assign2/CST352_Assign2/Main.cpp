//Main.cpp
//Bikesh Maharjan
//CST 352 Spring 2017
//Assignment 2

#include <iostream>
#include "MemoryPool.h"
#include "StringQueue.h"

void Test(MemoryPool * pool);

int main() {
	FirstFitPool ffpool(100);
	Test(&ffpool);

	BestFitPool bfpool(100);
	Test(&bfpool);

	return 0;
}

void Test(MemoryPool * pool){
	StringQueue q1(pool);
	q1.Insert("Hi");
	q1.Insert("There");
	std::cout << q1.Peek() << std::endl;
	q1.Remove();
	q1.Insert("What");
	std::cout << q1.Peek() << std::endl;
	q1.Remove();
	std::cout << q1.Peek() << std::endl;
	q1.Remove();
}