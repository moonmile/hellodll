// hellodll.cpp : DLL アプリケーション用にエクスポートされる関数を定義します。
//

#include "stdafx.h"
#include <string>
static std::string _str = "";
static std::wstring _wstr = L"";
extern "C" {
	__declspec(dllexport) int __stdcall Add(int x, int y) {
		return x + y;
	}

	__declspec(dllexport) void __stdcall SetNameStr(char *t) {
		_str = std::string(t);
	}
	__declspec(dllexport) char * __stdcall GetNameStr() {
		return (char*)_str.c_str();
	}
	__declspec(dllexport) void __stdcall SetNameWStr(const wchar_t *t) {
		_wstr = std::wstring(t);
	}
	__declspec(dllexport) const wchar_t * __stdcall GetNameWStr() {
		return _wstr.c_str();
	}
}

