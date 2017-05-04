//MemoryPool.h
//Bikesh Maharjan
//CST 352
//Assignment 2
#pragma once

class OutofMemoryException
{

};

class MemoryPool
{
protected:
	void * pool;
	int size;
	MemoryPool(int size);

public:
	virtual void * Allocate(int nbytes) = 0;
	virtual void Free(void * block) = 0;
};

class FirstFitPool : public MemoryPool {
public:
	FirstFitPool(int size);
	virtual void * Allocate(int nbytes);
	virtual void Free(void * block);
};

class BestFitPool : public MemoryPool {
public:
	BestFitPool(int size);
	virtual void * Allocate(int nbytes);
	virtual void Free(void * block);
};