﻿using System;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Linq;

namespace DecaTec.WebDav.WebDavArtifacts
{
    /// <summary>
    /// Class representing an 'activelock' XML element for WebDAV communication.
    /// </summary>
    [DataContract]
    [XmlType(TypeName = WebDavConstants.ActiveLock, Namespace = WebDavConstants.DAV)]
    [XmlRoot(Namespace = WebDavConstants.DAV, IsNullable = false)]
    public class ActiveLock
    {
        /// <summary>
        /// Gets or sets the <see cref="DecaTec.WebDav.WebDavArtifacts.LockScope"/>.
        /// </summary>
        [XmlElement(ElementName = WebDavConstants.LockScope)]
        public LockScope LockScope
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="DecaTec.WebDav.WebDavArtifacts.LockType"/>.
        /// </summary>
        [XmlElement(ElementName = WebDavConstants.LockType)]
        public LockType LockType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Depth.
        /// </summary>
        [XmlElement(ElementName = WebDavConstants.Depth)]
        public string Depth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the href of the owner.
        /// </summary>
        [XmlIgnore]
        public string OwnerHref
        {
            get
            {
                var elem = this.OwnerRaw.Elements().FirstOrDefault(x => x.Name.LocalName == WebDavConstants.Href);

                if (elem == null)
                    return string.Empty;
                else
                {
                    var href = elem.Value;
                    return href;
                }
            }
            set
            {
                if (this.OwnerRaw != null)
                    throw new InvalidOperationException("The OwnerHref field can only be set when the OwnerRaw field is empty");

                this.OwnerRaw = new XElement(WebDavConstants.DavNs + WebDavConstants.Owner,
                    new XElement(WebDavConstants.DavNs + WebDavConstants.Href, value));
            }
        }

        /// <summary>
        /// Gets or sets the raw owner info.
        /// </summary>
        [XmlAnyElement(Name = WebDavConstants.Owner, Namespace = WebDavConstants.DAV)]
        public XElement OwnerRaw
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Timeout.
        /// </summary>
        [XmlElement(ElementName = WebDavConstants.Timeout)]
        public string Timeout
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="DecaTec.WebDav.WebDavArtifacts.WebDavLockToken"/>.
        /// </summary>
        [XmlElement(ElementName = WebDavConstants.LockToken, IsNullable = false)]
        public WebDavLockToken LockToken
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="DecaTec.WebDav.WebDavArtifacts.LockRoot"/>.
        /// </summary>
        [XmlElement(ElementName = WebDavConstants.LockRoot, IsNullable = false)]
        public LockRoot LockRoot
        {
            get;
            set;
        }
    }
}
