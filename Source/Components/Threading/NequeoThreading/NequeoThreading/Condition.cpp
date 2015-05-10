/* Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
*  Copyright :     Copyright � Nequeo Pty Ltd 2014 http://www.nequeo.com.au/
*
*  File :          Condition.cpp
*  Purpose :       Condition class.
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

#include "stdafx.h"

#include "Condition.h"

namespace Nequeo {
	namespace Threading
	{
		Condition::Condition()
		{
		}

		Condition::~Condition()
		{
		}


		void Condition::signal()
		{
			FastMutex::ScopedLock lock(_mutex);

			if (!_waitQueue.empty())
			{
				_waitQueue.front()->set();
				dequeue();
			}
		}


		void Condition::broadcast()
		{
			FastMutex::ScopedLock lock(_mutex);

			for (WaitQueue::iterator it = _waitQueue.begin(); it != _waitQueue.end(); ++it)
			{
				(*it)->set();
			}
			_waitQueue.clear();
		}


		void Condition::enqueue(Event& event)
		{
			_waitQueue.push_back(&event);
		}


		void Condition::dequeue()
		{
			_waitQueue.pop_front();
		}


		void Condition::dequeue(Event& event)
		{
			for (WaitQueue::iterator it = _waitQueue.begin(); it != _waitQueue.end(); ++it)
			{
				if (*it == &event)
				{
					_waitQueue.erase(it);
					break;
				}
			}
		}
	}
}