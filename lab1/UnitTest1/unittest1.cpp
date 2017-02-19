#include "stdafx.h"
#include "CppUnitTest.h"
#include "..\Lab1\Lab1.cpp"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace UnitTest1
{		
	TEST_CLASS(UnitTest1)
	{
	public:
		
		TEST_METHOD(TestMethod1)
		{
			Assert::AreEqual(static_cast<float>(-2.0),Determine(1,2,3,4));
		}

	};
}