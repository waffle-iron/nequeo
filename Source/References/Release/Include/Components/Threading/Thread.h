/* Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
*  Copyright :     Copyright � Nequeo Pty Ltd 2014 http://www.nequeo.com.au/
*
*  File :          Thread.h
*  Purpose :       Thread class.
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

#ifndef _THREAD_H
#define _THREAD_H

#include "GlobalThreading.h"

#include "Mutex.h"
#include "Thread_WIN32.h"
#include "Priority.h"

namespace Nequeo {
	namespace Threading
	{
		class Runnable;
		class ThreadLocalStorage;

		/// This class implements a platform-independent
		/// wrapper to an operating system thread.
		///
		/// Every Thread object gets a unique (within
		/// its process) numeric thread ID.
		/// Furthermore, a thread can be assigned a name.
		/// The name of a thread can be changed at any time.
		class Thread : private ThreadImpl
		{
		public:
			typedef ThreadImpl::TIDImpl TID;

			using ThreadImpl::Callable;

			Thread();
			/// Creates a thread. Call start() to start it.

			Thread(const std::string& name);
			/// Creates a named thread. Call start() to start it.

			~Thread();
			/// Destroys the thread.

			int id() const;
			/// Returns the unique thread ID of the thread.

			TID tid() const;
			/// Returns the native thread ID of the thread.

			std::string name() const;
			/// Returns the name of the thread.

			std::string getName() const;
			/// Returns the name of the thread.

			void setName(const std::string& name);
			/// Sets the name of the thread.

			void setPriority(Priority prio);
			/// Sets the thread's priority.
			///
			/// Some platform only allow changing a thread's priority
			/// if the process has certain privileges.

			Priority getPriority() const;
			/// Returns the thread's priority.

			void setOSPriority(int prio, int policy = Nequeo::Threading::POLICY_DEFAULT);
			/// Sets the thread's priority, using an operating system specific
			/// priority value. Use getMinOSPriority() and getMaxOSPriority() to
			/// obtain mininum and maximum priority values. Additionally,
			/// a scheduling policy can be specified. The policy is currently
			/// only used on POSIX platforms where the values SCHED_OTHER (default),
			/// SCHED_FIFO and SCHED_RR are supported.

			int getOSPriority() const;
			/// Returns the thread's priority, expressed as an operating system
			/// specific priority value.
			///
			/// May return 0 if the priority has not been explicitly set.

			static int getMinOSPriority(int policy = Nequeo::Threading::POLICY_DEFAULT);
			/// Returns the mininum operating system-specific priority value,
			/// which can be passed to setOSPriority() for the given policy.

			static int getMaxOSPriority(int policy = Nequeo::Threading::POLICY_DEFAULT);
			/// Returns the maximum operating system-specific priority value,
			/// which can be passed to setOSPriority() for the given policy.

			void setStackSize(int size);
			/// Sets the thread's stack size in bytes.
			/// Setting the stack size to 0 will use the default stack size.
			/// Typically, the real stack size is rounded up to the nearest
			/// page size multiple.

			int getStackSize() const;
			/// Returns the thread's stack size in bytes.
			/// If the default stack size is used, 0 is returned.

			void start(Runnable& target);
			/// Starts the thread with the given target.
			///
			/// Note that the given Runnable object must be
			/// valid during the entire lifetime of the thread, as
			/// only a reference to it is stored internally.

			void start(Callable target, void* pData = 0);
			/// Starts the thread with the given target and parameter.

			void join();
			/// Waits until the thread completes execution.	
			/// If multiple threads try to join the same
			/// thread, the result is undefined.

			void join(long milliseconds);
			/// Waits for at most the given interval for the thread
			/// to complete. Throws a TimeoutException if the thread
			/// does not complete within the specified time interval.

			bool tryJoin(long milliseconds);
			/// Waits for at most the given interval for the thread
			/// to complete. Returns true if the thread has finished,
			/// false otherwise.

			bool isRunning() const;
			/// Returns true if the thread is running.

			static void sleep(long milliseconds);
			/// Suspends the current thread for the specified
			/// amount of time.

			static void yield();
			/// Yields cpu to other threads.

			static Thread* current();
			/// Returns the Thread object for the currently active thread.
			/// If the current thread is the main thread, 0 is returned.

			static TID currentTid();
			/// Returns the native thread ID for the current thread.    

		protected:
			ThreadLocalStorage& tls();
			/// Returns a reference to the thread's local storage.

			void clearTLS();
			/// Clears the thread's local storage.

			std::string makeName();
			/// Creates a unique name for a thread.

			static int uniqueId();
			/// Creates and returns a unique id for a thread.

		private:
			Thread(const Thread&);
			Thread& operator = (const Thread&);

			int                 _id;
			std::string         _name;
			ThreadLocalStorage* _pTLS;
			mutable FastMutex   _mutex;

			friend class ThreadLocalStorage;
			friend class PooledThread;
		};


		//
		// inlines
		//
		inline Thread::TID Thread::tid() const
		{
			return tidImpl();
		}


		inline int Thread::id() const
		{
			return _id;
		}


		inline std::string Thread::name() const
		{
			FastMutex::ScopedLock lock(_mutex);

			return _name;
		}


		inline std::string Thread::getName() const
		{
			FastMutex::ScopedLock lock(_mutex);

			return _name;
		}


		inline bool Thread::isRunning() const
		{
			return isRunningImpl();
		}


		inline void Thread::sleep(long milliseconds)
		{
			sleepImpl(milliseconds);
		}


		inline void Thread::yield()
		{
			yieldImpl();
		}


		inline Thread* Thread::current()
		{
			return static_cast<Thread*>(currentImpl());
		}


		inline void Thread::setOSPriority(int prio, int policy)
		{
			setOSPriorityImpl(prio, policy);
		}


		inline int Thread::getOSPriority() const
		{
			return getOSPriorityImpl();
		}


		inline int Thread::getMinOSPriority(int policy)
		{
			return ThreadImpl::getMinOSPriorityImpl(policy);
		}


		inline int Thread::getMaxOSPriority(int policy)
		{
			return ThreadImpl::getMaxOSPriorityImpl(policy);
		}


		inline void Thread::setStackSize(int size)
		{
			setStackSizeImpl(size);
		}


		inline int Thread::getStackSize() const
		{
			return getStackSizeImpl();
		}


		inline Thread::TID Thread::currentTid()
		{
			return currentTidImpl();
		}
	}
}
#endif
