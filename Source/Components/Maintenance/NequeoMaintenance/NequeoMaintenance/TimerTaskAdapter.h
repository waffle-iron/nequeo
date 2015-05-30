/* Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
*  Copyright :     Copyright � Nequeo Pty Ltd 2014 http://www.nequeo.com.au/
*
*  File :          TimerTaskAdapter.h
*  Purpose :       TimerTaskAdapter header.
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

#ifndef _TIMERTASKADAPTER_H
#define _TIMERTASKADAPTER_H

#include "GlobalMaintenance.h"
#include "TimerTask.h"

namespace Nequeo {
	namespace Maintenance
	{
		template <class C>
		class TimerTaskAdapter : public TimerTask
			/// This class template simplifies the implementation
			/// of TimerTask objects by allowing a member function
			/// of an object to be called as task. 
		{
		public:
			typedef void (C::*Callback)(TimerTask&);

			TimerTaskAdapter(C& object, Callback method) : _pObject(&object), _method(method)
				/// Creates the TimerTaskAdapter, using the given 
				/// object and its member function as task target.
				///
				/// The member function must accept one argument,
				/// a reference to a TimerTask object.
			{
			}

			void run()
			{
				(_pObject->*_method)(*this);
			}

		protected:
			~TimerTaskAdapter()
				/// Destroys the TimerTaskAdapter.
			{
			}

		private:
			TimerTaskAdapter();

			C*       _pObject;
			Callback _method;
		};
	}
}
#endif