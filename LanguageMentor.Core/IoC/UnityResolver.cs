using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Unity;

namespace LanguageMentor.Core.IoC
{
    /// <summary>
    /// Resolves dependencies using Unity
    /// </summary>
    public class UnityResolver : IDependencyResolver
    {
        private readonly IUnityContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnityResolver"/> class.
        /// </summary>
        /// <param name="container">Container</param>
        /// <exception cref="ArgumentNullException"><paramref name="container"/> must not be null</exception>
        public UnityResolver(IUnityContainer container)
        {
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        /// <inheritdoc />
        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        /// <inheritdoc />
        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        /// <inheritdoc />
        public IDependencyScope BeginScope()
        {
            var child = _container.CreateChildContainer();
            return new UnityResolver(child);
        }

        /// <inheritdoc />
        public void Dispose()
        {
            Dispose(true);
        }

        /// <inheritdoc />
        protected virtual void Dispose(bool disposing)
        {
            _container.Dispose();
        }
    }
}
