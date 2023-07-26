using FluentValidation.TestHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Core
{
    public readonly struct Result<TValue, TError>
    {
        private readonly TValue _value;
        public TValue Value { get { return _value; } }
        private readonly TError _error;
        public TError Error { get { return _error; } }

        public bool IsError { get; }
       
        public bool IsSuccess => !IsError;

        public Result(TValue value)
        {
            _value = value;
            IsError = false;
            _error = default;
        }

        public Result(TError error)
        {
            _error = error;
            IsError = true;
            _value = default;
        }

        public static implicit operator Result<TValue, TError>(TValue value) 
        {  
            return new Result<TValue, TError>(value); 
        }

        public static implicit operator Result<TValue, TError>(TError error) 
        {  
            return new Result<TValue, TError>(error); 
        }

        /// <summary>
        /// Would use this if trying to create an IActionResult for a Web App / API.
        /// Potentially, reply with some other action/endpoint or BadRequest for the error.
        /// </summary>
        public TResult Match<TResult>(
            Func<TValue, TResult> success,
            Func<TError, TResult> failure)
        {
            return IsError ? failure(_error) : success(_value);
        }
    }
}
