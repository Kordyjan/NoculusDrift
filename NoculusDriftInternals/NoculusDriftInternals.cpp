// This is the main DLL file.


#include "stdafx.h"
#include <cstdio>
#include <Windows.h>

#include "NoculusDriftInternals.h"

using namespace std;
using namespace NoculusDriftInternals;

UINT Input::SendKey(WORD code)
{
	INPUT input;
	input.type = INPUT_KEYBOARD;
	input.ki.wVk = code;
	input.ki.wScan = 0;
	input.ki.dwFlags = 0;
	input.ki.time = 0;
	input.ki.dwExtraInfo = Api::GetMessageExtraInfo();
	return Api::SendInput(1, &input, sizeof(input));
}