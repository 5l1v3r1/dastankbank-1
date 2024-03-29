// Copyright(C) 2002-2009 Hugo Rumayor Montemayor, All rights reserved.
using System;
using System.Text;

namespace Id3Lib
{
    /// <summary>
    /// Abstract base frame that provides common functionality to all the frames.
    /// </summary>
    public abstract class FrameBase : IFrame
    {
        #region Fields
        private string _frameId;
        private ushort _flags;
        #endregion

        #region Constructor
        internal FrameBase(string frameId)
        {
            if (frameId == null)
                throw new ArgumentNullException("frameId");

            if (frameId.Contains(" "))
                throw new InvalidTagException("Invalid frame type, the frameId can't contain blank spaces");

            if (frameId.Length != 4)
                throw new InvalidTagException("Invalid frame type: '" + frameId + "', it must be 4 characters long.");

            _frameId = frameId;
        }
        #endregion

        #region  Properties
        /// <summary>
        /// Tag frame flags
        /// </summary>
        public ushort Flags
        {
            get { return _flags; }
            set { _flags = value; }
        }

        /// <summary>
        /// ID3 FrameId frame type
        /// </summary>
        public string FrameId
        {
            get { return _frameId; }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Load frame form binary data
        /// </summary>
        /// <param name="frame">binary frame representation</param>
        public abstract void Parse(byte[] frame);
        /// <summary>
        /// Save frame to binary data
        /// </summary>
        /// <returns>binary frame representation</returns>
        public abstract byte[] Make();
        #endregion
    }
}
