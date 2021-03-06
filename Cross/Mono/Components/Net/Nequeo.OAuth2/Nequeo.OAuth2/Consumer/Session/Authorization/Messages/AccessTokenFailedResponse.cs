﻿/*  Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
 *  Copyright :     Copyright © Nequeo Pty Ltd 2012 http://www.nequeo.com.au/
 * 
 *  File :          
 *  Purpose :       
 * 
 */

#region Nequeo Pty Ltd License
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
#endregion

namespace Nequeo.Net.OAuth2.Consumer.Session.Authorization.Messages
{
	using System;
	using System.Net;

    using Nequeo.Net.Core.Messaging;
    using Nequeo.Net.Core.Messaging.Reflection;
    using Nequeo.Net.OAuth2.Framework;
    using Nequeo.Net.OAuth2.Framework.ChannelElements;
    using Nequeo.Net.OAuth2.Framework.Messages;
    using Nequeo.Net.OAuth2.Consumer.Session.Authorization.ChannelElements;

	/// <summary>
	/// A response from the Authorization Server to the Client to indicate that a
	/// request for an access token renewal failed, probably due to an invalid
	/// refresh token.
	/// </summary>
	/// <remarks>
	/// This message type is shared by the Web App, Rich App, and Username/Password profiles.
	/// </remarks>
	internal class AccessTokenFailedResponse : MessageBase, IHttpDirectResponse {
		/// <summary>
		/// A value indicating whether this error response is in result to a request that had invalid client credentials which were supplied in the HTTP Authorization header.
		/// </summary>
		private readonly bool invalidClientCredentialsInAuthorizationHeader;

		/// <summary>
		/// The headers to include in the response.
		/// </summary>
		private readonly WebHeaderCollection headers = new WebHeaderCollection();

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokenFailedResponse"/> class.
		/// </summary>
		/// <param name="request">The faulty request.</param>
		internal AccessTokenFailedResponse(AccessTokenRequestBase request)
			: base(request) {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokenFailedResponse"/> class.
		/// </summary>
		/// <param name="request">The faulty request.</param>
		/// <param name="invalidClientCredentialsInAuthorizationHeader">A value indicating whether this error response is in result to a request that had invalid client credentials which were supplied in the HTTP Authorization header.</param>
		internal AccessTokenFailedResponse(AccessTokenRequestBase request, bool invalidClientCredentialsInAuthorizationHeader)
			: base(request) {
			this.invalidClientCredentialsInAuthorizationHeader = invalidClientCredentialsInAuthorizationHeader;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AccessTokenFailedResponse"/> class.
		/// </summary>
		/// <param name="version">The protocol version.</param>
		internal AccessTokenFailedResponse(Version version = null)
			: base(version ?? Protocol.Default.Version) {
		}

		#region IHttpDirectResponse Members

		/// <summary>
		/// Gets the HTTP status code that the direct response should be sent with.
		/// </summary>
		HttpStatusCode IHttpDirectResponse.HttpStatusCode {
			get { return this.invalidClientCredentialsInAuthorizationHeader ? HttpStatusCode.Unauthorized : HttpStatusCode.BadRequest; }
		}

		/// <summary>
		/// Gets the HTTP headers to add to the response.
		/// </summary>
		/// <value>May be an empty collection, but must not be <c>null</c>.</value>
		public WebHeaderCollection Headers {
			get { return this.headers; }
		}

		#endregion

		/// <summary>
		/// Gets or sets the error.
		/// </summary>
		/// <value>One of the values given in <see cref="Protocol.AccessTokenRequestErrorCodes"/>.</value>
		[MessagePart(Protocol.error, IsRequired = true)]
		internal string Error { get; set; }

		/// <summary>
		/// Gets or sets a human readable description of the error.
		/// </summary>
		/// <value>Human-readable text providing additional information, used to assist in the understanding and resolution of the error that occurred.</value>
		[MessagePart(Protocol.error_description, IsRequired = false)]
		internal string ErrorDescription { get; set; }

		/// <summary>
		/// Gets or sets the location of the web page that describes the error and possible resolution.
		/// </summary>
		/// <value>A URI identifying a human-readable web page with information about the error, used to provide the end-user with additional information about the error.</value>
		[MessagePart(Protocol.error_uri, IsRequired = false)]
		internal Uri ErrorUri { get; set; }
	}
}
