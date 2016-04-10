/* Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
*  Copyright :     Copyright � Nequeo Pty Ltd 2016 http://www.nequeo.com.au/
*
*  File :          AACProfileInfo.h
*  Purpose :       AACProfileInfo class.
*
*/

/*
Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the "Software"), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.
*/

#pragma once

#ifndef _AACPROFILEINFO_H
#define _AACPROFILEINFO_H

#include "stdafx.h"

namespace Nequeo
{
	namespace Media
	{
		/// <summary>
		/// A structure to encapsulate AAC audio.
		/// </summary>
		struct AACProfileInfo
		{
			UINT32  samplesPerSec;
			UINT32  numChannels;
			UINT32  bitsPerSample;
			UINT32  bytesPerSec;
			UINT32  aacProfile;
		};

		/// <summary>
		/// A structure to encapsulate AAC audio.
		/// </summary>
		public ref struct AACProfile
		{
			unsigned int SamplesPerSec;
			unsigned int NumberChannels;
			unsigned int BitsPerSample;
			unsigned int BytesPerSec;
			unsigned int AacProfile;
		};
	}
}
#endif