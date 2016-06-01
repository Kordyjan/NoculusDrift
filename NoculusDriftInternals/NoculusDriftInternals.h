// NoculusDriftInternals.h

#pragma once

using namespace System;
using namespace System::Runtime::InteropServices;


namespace NoculusDriftInternals {

	public ref class Input
	{
	public:
		UINT SendKey(WORD code); // codes: https://msdn.microsoft.com/en-gb/library/windows/desktop/dd375731%28v=vs.85%29.aspx
	};

	public ref class Api
	{
	public:
		[DllImport("user32.dll")]
		static UINT SendInput(_In_ UINT nInputs, _In_ LPINPUT pInputs, _In_ int cbSize);
		
		[DllImport("user32.dll")]
		static LPARAM GetMessageExtraInfo();
	};
}
