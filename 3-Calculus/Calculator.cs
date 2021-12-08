using System.Linq;
using System.Runtime.ConstrainedExecution;
using ComplexAlgebra;

namespace Calculus
{
    /// <summary>
    /// A calculator for <see cref="Complex"/> numbers, supporting 2 operations ('+', '-').
    /// The calculator visualizes a single value at a time.
    /// Users may change the currently shown value as many times as they like.
    /// Whenever an operation button is chosen, the calculator memorises the currently shown value and resets it.
    /// Before resetting, it performs any pending operation.
    /// Whenever the final result is requested, all pending operations are performed and the final result is shown.
    /// The calculator also supports resetting.
    /// </summary>
    ///
    /// HINT: model operations as constants
    /// HINT: model the following _public_ properties methods
    /// HINT: - a property/method for the currently shown value
    /// HINT: - a property/method to let the user request the final result
    /// HINT: - a property/method to let the user reset the calculator
    /// HINT: - a property/method to let the user request an operation
    /// HINT: - the usual ToString() method, which is helpful for debugging
    /// HINT: - you may exploit as many _private_ fields/methods/properties as you like
    ///
    /// TODO: implement the calculator class in such a way that the Program below works as expected
    class Calculator
    {
        public const char OperationPlus = '+';
        public const char OperationMinus = '-';

        private Complex _value;
        private Complex _result;
        private char _currOperation;
        
        public Complex Value
        {
            get => _value;
            set
            {
                _value = value;
                if (_currOperation == OperationPlus)
                {
                    _result = _result.Plus(value);
                }
                else if (_currOperation == OperationMinus)
                {
                    _result = _result.Minus(value);
                }
                else
                {
                    _result = value;
                }

                _currOperation = 'n';
            } 
        }

        private bool HasOp() => _currOperation == OperationMinus || _currOperation == OperationPlus;

        public char Operation
        {
            set => this._currOperation = value; 
        }

        public void ComputeResult() => _value = _result;

        public void Reset()
        {
            _result = null;
            _value = null;
        }

        public override string ToString()
        {
            var s = (_value != null ? _value.ToString() : "null") + ", ";
            if (HasOp())
            {
                s += _currOperation;
            }
            else
            {
                s += "null";
            }

            return s;
        }
    }
}