using System;
using System.Collections.Generic;
using Jellyfin.Plugin.TmdbAdult.Configuration;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.TmdbAdult
{
    /// <summary>
    /// Tmdb Plugin.
    /// </summary>
    public class TmdbPlugin : BasePlugin<PluginConfiguration>, IHasWebPages
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TmdbPlugin"/> class.
        /// </summary>
        /// <param name="applicationPaths">Instance of the <see cref="IApplicationPaths"/> interface.</param>
        /// <param name="xmlSerializer">Instance of the <see cref="IXmlSerializer"/> interface.</param>
        public TmdbPlugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
            Instance = this;
        }

        /// <summary>
        /// Gets current plugin instance.
        /// </summary>
        public static TmdbPlugin? Instance { get; private set; }

        /// <inheritdoc />
        public override string Name => "TheMovieDbAdult";

        /// <inheritdoc />
        public override Guid Id => new Guid("6ce05665-2256-48a4-a2a8-f2bad5e0003c");

        /// <inheritdoc />
        public IEnumerable<PluginPageInfo> GetPages()
        {
            yield return new PluginPageInfo
            {
                Name = Name,
                EmbeddedResourcePath = $"{GetType().Namespace}.Configuration.config.html"
            };
        }
    }
}
