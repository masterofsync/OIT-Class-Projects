//MemoryPool.cpp
//Bikesh Maharjan
//CST 352
//Assignment 2

#include "MemoryPool.h"
#include <stdlib.h>

MemoryPool::MemoryPool(int size)
{
}

FirstFitPool::FirstFitPool(int size) : MemoryPool(size)
{
}

void * FirstFitPool::Allocate(int nbytes)
{
	return NULL;
}

void FirstFitPool::Free(void * block)
{
}

BestFitPool::BestFitPool(int size):MemoryPool(size)
{
}

void * BestFitPool::Allocate(int nbytes)
{
	return NULL;
}

void BestFitPool::Free(void * block)
{
}
