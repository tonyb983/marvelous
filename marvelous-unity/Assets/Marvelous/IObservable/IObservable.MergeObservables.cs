using System;
using System.Collections.Generic;

namespace Marvelous
{
    public static partial class Marvelous
    {
        /// <summary>
        /// Merges two observables into one. It uses createCombinedModel to create what is returned on every OnNext.
        /// </summary>
        /// <param name="observable1">IObservable to be merged.</param>
        /// <param name="observable2">IObservable to be merged.</param>
        /// <param name="createCombinedModel">Used to merge and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="M">Type of the new merged IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> MergeObservables<T1, T2, M>(
            IObservable<T1> observable1, IObservable<T2> observable2,
            Func<T1, T2, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2))
        {
            return new MergeObservables<T1, T2, M>(observable1, observable2, createCombinedModel, initialValue1, initialValue2);
        }

        /// <summary>
        /// Merges three observables into one. It uses createCombinedModel to create what is returned on every OnNext.
        /// </summary>
        /// <param name="observable1">IObservable to be merged.</param>
        /// <param name="observable2">IObservable to be merged.</param>
        /// <param name="observable3">IObservable to be merged.</param>
        /// <param name="createCombinedModel">Used to merge and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="M">Type of the new merged IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> MergeObservables<T1, T2, T3, M>(
            IObservable<T1> observable1, IObservable<T2> observable2, IObservable<T3> observable3,
            Func<T1, T2, T3, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3))
        {
            return new MergeObservables<T1, T2, T3, M>(observable1, observable2, observable3, createCombinedModel, initialValue1, initialValue2, initialValue3);
        }

        /// <summary>
        /// Merges four observables into one. It uses createCombinedModel to create what is returned on every OnNext.
        /// </summary>
        /// <param name="observable1">IObservable to be merged.</param>
        /// <param name="observable2">IObservable to be merged.</param>
        /// <param name="observable3">IObservable to be merged.</param>
        /// <param name="observable4">IObservable to be merged.</param>
        /// <param name="createCombinedModel">Used to merge and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <param name="initialValue4">Initial value of observerable4.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="T4">The type of the fourth IObservable.</typeparam>
        /// <typeparam name="M">Type of the new merged IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> MergeObservables<T1, T2, T3, T4, M>(
            IObservable<T1> observable1, IObservable<T2> observable2, IObservable<T3> observable3, IObservable<T4> observable4,
            Func<T1, T2, T3, T4, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4))
        {
            return new MergeObservables<T1, T2, T3, T4, M>(observable1, observable2, observable3, observable4, createCombinedModel, initialValue1, initialValue2, initialValue3, initialValue4);
        }

        /// <summary>
        /// Merges five observables into one. It uses createCombinedModel to create what is returned on every OnNext.
        /// </summary>
        /// <param name="observable1">IObservable to be merged.</param>
        /// <param name="observable2">IObservable to be merged.</param>
        /// <param name="observable3">IObservable to be merged.</param>
        /// <param name="observable4">IObservable to be merged.</param>
        /// <param name="observable5">IObservable to be merged.</param>
        /// <param name="createCombinedModel">Used to merge and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <param name="initialValue4">Initial value of observerable4.</param>
        /// <param name="initialValue5">Initial value of observerable5.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="T4">The type of the fourth IObservable.</typeparam>
        /// <typeparam name="T5">The type of the fifth IObservable.</typeparam>
        /// <typeparam name="M">Type of the new merged IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> MergeObservables<T1, T2, T3, T4, T5, M>(
            IObservable<T1> observable1, IObservable<T2> observable2, IObservable<T3> observable3, IObservable<T4> observable4, IObservable<T5> observable5,
            Func<T1, T2, T3, T4, T5, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4), T5 initialValue5 = default(T5))
        {
            return new MergeObservables<T1, T2, T3, T4, T5, M>(observable1, observable2, observable3, observable4, observable5, createCombinedModel, initialValue1, initialValue2, initialValue3, initialValue4, initialValue5);
        }
    }

    public static partial class Extensions
    {
        /// <summary>
        /// Merges 2 observables into one. It uses createCombinedModel to create what is returned on every OnNext.
        /// </summary>
        /// <param name="observable1">IObservable to be merged.</param>
        /// <param name="observable2">IObservable to be merged.</param>
        /// <param name="createCombinedModel">Used to merge and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="M">Type of the new merged IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> MergeObservables<T1, T2, M>(
            this IObservable<T1> observable1, IObservable<T2> observable2,
            Func<T1, T2, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2))
        {
            return Marvelous.MergeObservables<T1, T2, M>(observable1, observable2, createCombinedModel, initialValue1, initialValue2);
        }

        /// <summary>
        /// Merges three observables into one. It uses createCombinedModel to create what is returned on every OnNext.
        /// </summary>
        /// <param name="observable1">IObservable to be merged.</param>
        /// <param name="observable2">IObservable to be merged.</param>
        /// <param name="observable3">IObservable to be merged.</param>
        /// <param name="createCombinedModel">Used to merge and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="M">Type of the new merged IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> MergeObservables<T1, T2, T3, M>(
            this IObservable<T1> observable1, IObservable<T2> observable2, IObservable<T3> observable3,
            Func<T1, T2, T3, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3))
        {
            return Marvelous.MergeObservables<T1, T2, T3, M>(observable1, observable2, observable3, createCombinedModel, initialValue1, initialValue2, initialValue3);
        }

        /// <summary>
        /// Merges four observables into one. It uses createCombinedModel to create what is returned on every OnNext.
        /// </summary>
        /// <param name="observable1">IObservable to be merged.</param>
        /// <param name="observable2">IObservable to be merged.</param>
        /// <param name="observable3">IObservable to be merged.</param>
        /// <param name="observable4">IObservable to be merged.</param>
        /// <param name="createCombinedModel">Used to merge and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <param name="initialValue4">Initial value of observerable4.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="T4">The type of the fourth IObservable.</typeparam>
        /// <typeparam name="M">Type of the new merged IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> MergeObservables<T1, T2, T3, T4, M>(
            this IObservable<T1> observable1, IObservable<T2> observable2, IObservable<T3> observable3, IObservable<T4> observable4,
            Func<T1, T2, T3, T4, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4))
        {
            return Marvelous.MergeObservables<T1, T2, T3, T4, M>(observable1, observable2, observable3, observable4, createCombinedModel, initialValue1, initialValue2, initialValue3, initialValue4);
        }

        /// <summary>
        /// Merges five observables into one. It uses createCombinedModel to create what is returned on every OnNext.
        /// </summary>
        /// <param name="observable1">IObservable to be merged.</param>
        /// <param name="observable2">IObservable to be merged.</param>
        /// <param name="observable3">IObservable to be merged.</param>
        /// <param name="observable4">IObservable to be merged.</param>
        /// <param name="observable5">IObservable to be merged.</param>
        /// <param name="createCombinedModel">Used to merge and create the observable value of the new IObservable.</param>
        /// <param name="initialValue1">Initial value of observerable1.</param>
        /// <param name="initialValue2">Initial value of observerable2.</param>
        /// <param name="initialValue3">Initial value of observerable3.</param>
        /// <param name="initialValue4">Initial value of observerable4.</param>
        /// <param name="initialValue5">Initial value of observerable5.</param>
        /// <typeparam name="T1">The type of the first IObservable.</typeparam>
        /// <typeparam name="T2">The type of the second IObservable.</typeparam>
        /// <typeparam name="T3">The type of the third IObservable.</typeparam>
        /// <typeparam name="T4">The type of the fourth IObservable.</typeparam>
        /// <typeparam name="T5">The type of the fifth IObservable.</typeparam>
        /// <typeparam name="M">Type of the new merged IObservable.</typeparam>
        /// <returns>A new IObservable of type M combining the IObservables sent in.</returns>
        public static IObservable<M> MergeObservables<T1, T2, T3, T4, T5, M>(
            this IObservable<T1> observable1, IObservable<T2> observable2, IObservable<T3> observable3, IObservable<T4> observable4, IObservable<T5> observable5,
            Func<T1, T2, T3, T4, T5, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4), T5 initialValue5 = default(T5))
        {
            return Marvelous.MergeObservables<T1, T2, T3, T4, T5, M>(observable1, observable2, observable3, observable4, observable5, createCombinedModel, initialValue1, initialValue2, initialValue3, initialValue4, initialValue5);
        }
    }

    internal class MergeObservables<T1, T2, M> : BaseObservable<M>, IObservable<M>
    {
        ProxyObserver<T1> _observer1;
        IDisposable _unsubscriber1;

        ProxyObserver<T2> _observer2;
        IDisposable _unsubscriber2;

        protected override bool IsCompleted { get { return _observer1.Completed && _observer2.Completed; } }

        public MergeObservables(IObservable<T1> observable1, IObservable<T2> observable2,
            Func<T1, T2, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2))
        {
            _observer1 = new ProxyObserver<T1>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t1) => _observers.ForEach((o) => o.OnNext(createCombinedModel(t1, _observer2 != null ? _observer2.LastValue : default(T2)))),
                initialValue: initialValue1
            );

            _observer2 = new ProxyObserver<T2>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t2) => _observers.ForEach((o) => o.OnNext(createCombinedModel(_observer1 != null ? _observer1.LastValue : default(T1), t2))),
                initialValue: initialValue2
            );

            _unsubscriber1 = observable1.Subscribe(_observer1);
            _unsubscriber2 = observable2.Subscribe(_observer2);
        }

        ~MergeObservables()
        {
            _unsubscriber1.Dispose();
            _unsubscriber2.Dispose();
        }
    }

    internal class MergeObservables<T1, T2, T3, M> : BaseObservable<M>, IObservable<M>
    {
        ProxyObserver<T1> _observer1;
        IDisposable _unsubscriber1;

        ProxyObserver<T2> _observer2;
        IDisposable _unsubscriber2;

        ProxyObserver<T3> _observer3;
        IDisposable _unsubscriber3;

        protected override bool IsCompleted { get { return _observer1.Completed && _observer2.Completed && _observer3.Completed; } }

        public MergeObservables(IObservable<T1> observable1, IObservable<T2> observable2, IObservable<T3> observable3,
            Func<T1, T2, T3, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3))
        {
            _observer1 = new ProxyObserver<T1>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t1) => _observers.ForEach((o) => o.OnNext(createCombinedModel(t1, _observer2 != null ? _observer2.LastValue : default(T2), _observer3 != null ? _observer3.LastValue : default(T3)))),
                initialValue: initialValue1
            );

            _observer2 = new ProxyObserver<T2>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t2) => _observers.ForEach((o) => o.OnNext(createCombinedModel(_observer1 != null ? _observer1.LastValue : default(T1), t2, _observer3 != null ? _observer3.LastValue : default(T3)))),
                initialValue: initialValue2
            );

            _observer3 = new ProxyObserver<T3>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t3) => _observers.ForEach((o) => o.OnNext(createCombinedModel(_observer1 != null ? _observer1.LastValue : default(T1), _observer2 != null ? _observer2.LastValue : default(T2), t3))),
                initialValue: initialValue3
            );

            _unsubscriber1 = observable1.Subscribe(_observer1);
            _unsubscriber2 = observable2.Subscribe(_observer2);
            _unsubscriber3 = observable3.Subscribe(_observer3);
        }

        ~MergeObservables()
        {
            _unsubscriber1.Dispose();
            _unsubscriber2.Dispose();
            _unsubscriber3.Dispose();
        }
    }

    internal class MergeObservables<T1, T2, T3, T4, M> : BaseObservable<M>, IObservable<M>
    {
        ProxyObserver<T1> _observer1;
        IDisposable _unsubscriber1;

        ProxyObserver<T2> _observer2;
        IDisposable _unsubscriber2;

        ProxyObserver<T3> _observer3;
        IDisposable _unsubscriber3;

        ProxyObserver<T4> _observer4;
        IDisposable _unsubscriber4;

        protected override bool IsCompleted { get { return _observer1.Completed && _observer2.Completed && _observer3.Completed && _observer4.Completed; } }

        public MergeObservables(IObservable<T1> observable1, IObservable<T2> observable2, IObservable<T3> observable3, IObservable<T4> observable4,
            Func<T1, T2, T3, T4, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4))
        {
            _observer1 = new ProxyObserver<T1>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t1) => _observers.ForEach((o) =>
                {
                    o.OnNext(createCombinedModel(
                        t1,
                        _observer2 != null ? _observer2.LastValue : default(T2),
                        _observer3 != null ? _observer3.LastValue : default(T3),
                        _observer4 != null ? _observer4.LastValue : default(T4)
                    ));
                }),
                initialValue: initialValue1
            );

            _observer2 = new ProxyObserver<T2>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t2) => _observers.ForEach((o) =>
                {
                    o.OnNext(createCombinedModel(
                        _observer1 != null ? _observer1.LastValue : default(T1),
                        t2,
                        _observer3 != null ? _observer3.LastValue : default(T3),
                        _observer4 != null ? _observer4.LastValue : default(T4)
                    ));
                }),
                initialValue: initialValue2
            );

            _observer3 = new ProxyObserver<T3>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t3) => _observers.ForEach((o) =>
                {
                    o.OnNext(createCombinedModel(
                        _observer1 != null ? _observer1.LastValue : default(T1),
                        _observer2 != null ? _observer2.LastValue : default(T2),
                        t3,
                        _observer4 != null ? _observer4.LastValue : default(T4)
                    ));
                }),
                initialValue: initialValue3
            );

            _observer4 = new ProxyObserver<T4>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t4) => _observers.ForEach((o) =>
                {
                    o.OnNext(createCombinedModel(
                        _observer1 != null ? _observer1.LastValue : default(T1),
                        _observer2 != null ? _observer2.LastValue : default(T2),
                        _observer3 != null ? _observer3.LastValue : default(T3),
                        t4
                    ));
                }),
                initialValue: initialValue4
            );

            _unsubscriber1 = observable1.Subscribe(_observer1);
            _unsubscriber2 = observable2.Subscribe(_observer2);
            _unsubscriber3 = observable3.Subscribe(_observer3);
            _unsubscriber4 = observable4.Subscribe(_observer4);
        }

        ~MergeObservables()
        {
            _unsubscriber1.Dispose();
            _unsubscriber2.Dispose();
            _unsubscriber3.Dispose();
            _unsubscriber4.Dispose();
        }
    }

    internal class MergeObservables<T1, T2, T3, T4, T5, M> : BaseObservable<M>, IObservable<M>
    {
        ProxyObserver<T1> _observer1;
        IDisposable _unsubscriber1;

        ProxyObserver<T2> _observer2;
        IDisposable _unsubscriber2;

        ProxyObserver<T3> _observer3;
        IDisposable _unsubscriber3;

        ProxyObserver<T4> _observer4;
        IDisposable _unsubscriber4;

        ProxyObserver<T5> _observer5;
        IDisposable _unsubscriber5;

        protected override bool IsCompleted { get { return _observer1.Completed && _observer2.Completed && _observer3.Completed && _observer4.Completed && _observer5.Completed; } }

        public MergeObservables(IObservable<T1> observable1, IObservable<T2> observable2, IObservable<T3> observable3, IObservable<T4> observable4, IObservable<T5> observable5,
            Func<T1, T2, T3, T4, T5, M> createCombinedModel,
            T1 initialValue1 = default(T1), T2 initialValue2 = default(T2), T3 initialValue3 = default(T3), T4 initialValue4 = default(T4), T5 initialValue5 = default(T5))
        {
            _observer1 = new ProxyObserver<T1>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t1) => _observers.ForEach((o) =>
                {
                    o.OnNext(createCombinedModel(
                        t1,
                        _observer2 != null ? _observer2.LastValue : default(T2),
                        _observer3 != null ? _observer3.LastValue : default(T3),
                        _observer4 != null ? _observer4.LastValue : default(T4),
                        _observer5 != null ? _observer5.LastValue : default(T5)
                    ));
                }),
                initialValue: initialValue1
            );

            _observer2 = new ProxyObserver<T2>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t2) => _observers.ForEach((o) =>
                {
                    o.OnNext(createCombinedModel(
                        _observer1 != null ? _observer1.LastValue : default(T1),
                        t2,
                        _observer3 != null ? _observer3.LastValue : default(T3),
                        _observer4 != null ? _observer4.LastValue : default(T4),
                        _observer5 != null ? _observer5.LastValue : default(T5)
                    ));
                }),
                initialValue: initialValue2
            );

            _observer3 = new ProxyObserver<T3>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t3) => _observers.ForEach((o) =>
                {
                    o.OnNext(createCombinedModel(
                        _observer1 != null ? _observer1.LastValue : default(T1),
                        _observer2 != null ? _observer2.LastValue : default(T2),
                        t3,
                        _observer4 != null ? _observer4.LastValue : default(T4),
                        _observer5 != null ? _observer5.LastValue : default(T5)
                    ));
                }),
                initialValue: initialValue3
            );

            _observer4 = new ProxyObserver<T4>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t4) => _observers.ForEach((o) =>
                {
                    o.OnNext(createCombinedModel(
                        _observer1 != null ? _observer1.LastValue : default(T1),
                        _observer2 != null ? _observer2.LastValue : default(T2),
                        _observer3 != null ? _observer3.LastValue : default(T3),
                        t4,
                        _observer5 != null ? _observer5.LastValue : default(T5)
                    ));
                }),
                initialValue: initialValue4
            );

            _observer5 = new ProxyObserver<T5>(
                onCompleted: OnCompleted,
                onError: OnError,
                onNext: (t5) => _observers.ForEach((o) =>
                {
                    o.OnNext(createCombinedModel(
                        _observer1 != null ? _observer1.LastValue : default(T1),
                        _observer2 != null ? _observer2.LastValue : default(T2),
                        _observer3 != null ? _observer3.LastValue : default(T3),
                        _observer4 != null ? _observer4.LastValue : default(T4),
                        t5
                    ));
                }),
                initialValue: initialValue5
            );

            _unsubscriber1 = observable1.Subscribe(_observer1);
            _unsubscriber2 = observable2.Subscribe(_observer2);
            _unsubscriber3 = observable3.Subscribe(_observer3);
            _unsubscriber4 = observable4.Subscribe(_observer4);
            _unsubscriber5 = observable5.Subscribe(_observer5);
        }

        ~MergeObservables()
        {
            _unsubscriber1.Dispose();
            _unsubscriber2.Dispose();
            _unsubscriber3.Dispose();
            _unsubscriber4.Dispose();
            _unsubscriber5.Dispose();
        }
    }

    internal class ProxyObserver<T> : IObserver<T>
    {
        public T LastValue;
        public bool Completed = false;

        private Action _onCompleted;
        public Action<Exception> _onError;
        public Action<T> _onNext;

        public ProxyObserver(Action onCompleted, Action<Exception> onError, Action<T> onNext, T initialValue)
        {
            this._onCompleted = onCompleted;
            this._onError = onError;
            this._onNext = onNext;
            LastValue = initialValue;
        }

        public void OnCompleted()
        {
            Completed = true;
            _onCompleted();
        }

        public void OnError(Exception error)
        {
            _onError(error);
        }

        public void OnNext(T value)
        {
            LastValue = value;
            _onNext(value);
        }
    }

    internal abstract class BaseObservable<T> : IObservable<T>
    {
        protected List<IObserver<T>> _observers = new List<IObserver<T>>();

        protected abstract bool IsCompleted { get; }

        public IDisposable Subscribe(IObserver<T> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
            return new ObservableUnsubscriber<T>(_observers, observer);
        }

        protected void OnCompleted()
        {
            if (IsCompleted)
            {
                for (int i = 0; _observers != null && i < _observers.Count; ++i)
                {
                    _observers[i].OnCompleted();
                }
            }
        }

        protected void OnError(Exception e)
        {
            for (int i = 0; _observers != null && i < _observers.Count; ++i)
            {
                _observers[i].OnError(e);
            }
        }
    }

    internal class ObservableUnsubscriber<T> : IDisposable
    {
        private List<IObserver<T>> _observers;
        private IObserver<T> _observer;

        public ObservableUnsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
            {
                _observers.Remove(_observer);
            }
        }
    }

}

