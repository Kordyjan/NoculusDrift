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

UINT NoculusDriftInternals::Input::MoveMouse(int x, int y)
{
	INPUT input;
	input.type = INPUT_MOUSE;
	input.mi.dx = x;
	input.mi.dy = y;
	input.mi.mouseData = 0;
	input.mi.dwFlags = MOUSEEVENTF_MOVE;
	input.mi.time = 0;
	input.mi.dwExtraInfo = Api::GetMessageExtraInfo();
	return Api::SendInput(1, &input, sizeof(input));
}
