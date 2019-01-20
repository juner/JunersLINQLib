using System;
using System.Collections.Generic;
using System.Text;

namespace Juners.Linq.Internal
{
    internal class Disposable : IDisposable
    {
        Action Action;
        Disposable(Action Action) => this.Action = Action ?? throw new ArgumentNullException(nameof(Action));
		public static IDisposable Create(Action Action) => new Disposable(Action);
        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Action();
                }
                disposedValue = true;
            }
        }
        public void Dispose() => Dispose(true);
        #endregion
    }
}
