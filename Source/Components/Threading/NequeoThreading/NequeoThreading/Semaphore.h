/* Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
*  Copyright :     Copyright � Nequeo Pty Ltd 2014 http://www.nequeo.com.au/
*
*  File :          Semaphore.h
*  Purpose :       Semaphore class.
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

#ifndef _SEMAPHORE_H
#define _SEMAPHORE_H

#include "GlobalThreading.h"

#include "Exceptions\Exception.h"
#include "Exceptions\ExceptionCode.h"
#include "Semaphore_WIN32.h"

namespace Nequeo {
	namespace Threading
	{
		/// A Semaphore is a synchronization object with the following 
		/// characteristics:
		/// A semaphore has a value that is constrained to be a non-negative
		/// integer and two atomic operations. The allowable operations are V 
		/// (here called set()) and P (here called wait()). A V (set()) operation 
		/// increases the value of the semaphore by one. 
		/// A P (wait()) operation decreases the value of the semaphore by one, 
		/// provided that can be done without violating the constraint that the 
		/// value be non-negative. A P (wait()) operation that is initiated when 
		/// the value of the semaphore is 0 suspends the calling thread. 
		/// The calling thread may continue when the value becomes positive again.
		class Semaphore : private SemaphoreImpl
		{
		public:
			Semaphore(int n);
			Semaphore(int n, int max);
			/// Creates the semaphore. The current value
			/// of the semaphore is given in n. The
			/// maximum value of the semaphore is given
			/// in max.
			/// If only n is given, it must be greater than
			/// zero.
			/// If both n and max are given, max must be
			/// greater than zero, n must be greater than
			/// or equal to zero and less than or equal
			/// to max.

			~Semaphore();
			/// Destroys the semaphore.

			void set();
			/// Increments the semaphore's value by one and
			/// thus signals the semaphore. Another thread
			/// waiting for the semaphore will be able
			/// to continue.

			void wait();
			/// Waits for the semaphore to become signalled.
			/// To become signalled, a semaphore's value must
			/// be greater than zero. 
			/// Decrements the semaphore's value by one.

			void wait(long milliseconds);
			/// Waits for the semaphore to become signalled.
			/// To become signalled, a semaphore's value must
			/// be greater than zero.
			/// Throws a TimeoutException if the semaphore
			/// does not become signalled within the specified
			/// time interval.
			/// Decrements the semaphore's value by one
			/// if successful.

			bool tryWait(long milliseconds);
			/// Waits for the semaphore to become signalled.
			/// To become signalled, a semaphore's value must
			/// be greater than zero.
			/// Returns true if the semaphore
			/// became signalled within the specified
			/// time interval, false otherwise.
			/// Decrements the semaphore's value by one
			/// if successful.

		private:
			Semaphore();
			Semaphore(const Semaphore&);
			Semaphore& operator = (const Semaphore&);
		};


		//
		// inlines
		//
		inline void Semaphore::set()
		{
			setImpl();
		}


		inline void Semaphore::wait()
		{
			waitImpl();
		}


		inline void Semaphore::wait(long milliseconds)
		{
			if (!waitImpl(milliseconds))
				throw Nequeo::Exceptions::TimeoutException();
		}


		inline bool Semaphore::tryWait(long milliseconds)
		{
			return waitImpl(milliseconds);
		}
	}
}
#endif
