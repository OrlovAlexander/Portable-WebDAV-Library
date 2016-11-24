﻿using System.Diagnostics;
using System.Runtime.Serialization;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DecaTec.WebDav.WebDavArtifacts
{
    /// <summary>
    /// Class representing an 'lockinfo' XML element for WebDAV communication.
    /// </summary>
    [DataContract]
    [XmlType(TypeName = WebDavConstants.LockInfo, Namespace = WebDavConstants.DAV)]
    [XmlRoot(Namespace = WebDavConstants.DAV, IsNullable = false)]
    public class LockInfo
    {
        private LockScope lockscopeField;
        private LockType locktypeField;
        private OwnerHref ownerField;

        /// <summary>
        /// Gets or sets the LockScope.
        /// </summary>
        [XmlElement(ElementName = WebDavConstants.LockScope)]
        public LockScope LockScope
        {
            get
            {
                return this.lockscopeField;
            }
            set
            {
                this.lockscopeField = value;
            }
        }

        /// <summary>
        /// Gets or sets the LockType.
        /// </summary>
        [XmlElement(ElementName = WebDavConstants.LockType)]
        public LockType LockType
        {
            get
            {
                return this.locktypeField;
            }
            set
            {
                this.locktypeField = value;
            }
        }

        /// <summary>
        /// Gets or sets the Owner.
        /// </summary>
        [XmlElement(ElementName = WebDavConstants.Owner)]
        public OwnerHref Owner
        {
            get
            {
                return this.ownerField;
            }
            set
            {
                this.ownerField = value;
            }
        }
    }
}
