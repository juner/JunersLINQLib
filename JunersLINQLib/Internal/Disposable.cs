using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Juners.Linq.Internal
{
    internal class Disposable : IDisposable
    {
        Action Action = null;
        Disposable(Action Action) => this.Action = Action ?? throw new ArgumentNullException(nameof(Action));
		public static IDisposable Create(Action Action) => new Disposable(Action);
        public override string ToString()
            => $"{nameof(Disposable)}("
            + string.Join(", ",new[] {
                Action == null ? $"IsDispose:{true}" : null,
            }.OfType<string>()) + ")";
        #region IDisposable Support

        protected virtual void Dispose(bool disposing)
        {
            if (Action != null)
            {
                Action?.Invoke();
                Action = null;
            }
        }
        public void Dispose() => Dispose(true);
        #endregion
    }
}
