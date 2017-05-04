//StringQueue.h
//Bikesh Maharjan
//CST 352
//Assignment 2

#pragma once

#include "MemoryPool.h"

class FullException {

};

class StringQueue {
public:
	StringQueue(MemoryPool *pool);
	void Insert(char *s);
	char * Peek();
	void Remove();
};