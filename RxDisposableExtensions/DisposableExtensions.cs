﻿using System;
using System.Reactive.Disposables;

namespace RxDisposableExtensions
{
    /// <summary>
    /// Provides extensions methods for IDisposable objects.
    /// </summary>
    public static class DisposableExtensions
    {
        /// <summary>
        /// Adds the specified observable item to the given <see cref="CompositeDisposable"/>.
        /// </summary>
        /// <typeparam name="T">The type of the object being added to the <see cref="CompositeDisposable"/>.</typeparam>
        /// <param name="observable">The <see cref="IDisposable"/> observable that is to be added to the specified <see cref="CompositeDisposable"/>.</param>
        /// <param name="disposables">The <see cref="CompositeDisposable "/> to which the observable is to be added.</param>
        /// <returns>The original observable object being added to the <see cref="CompositeDisposable"/>.</returns>
        public static T DisposeWith<T>(this T observable, CompositeDisposable disposables)
            where T : IDisposable
        {
            if (disposables == null)
            {
                throw new ArgumentNullException(nameof(disposables));
            }

            disposables.Add(observable);
            return observable;
        }
    }
}
