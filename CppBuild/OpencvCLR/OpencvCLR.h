#pragma once
#include <opencv2/opencv.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/core.hpp>

using namespace System;
using namespace cv;

namespace OpencvCLR {
	public ref class ClrImage
	{
	public:
		int openimage();
		void porting();
	};
}
