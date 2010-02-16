﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Id3Lib
{
    /// <summary>
    /// Interface that all tag frames share
    /// </summary>
    public interface IFrame
    {
        #region  Properties
        /// <summary>
        /// Tag frame flags
        /// </summary>
        ushort Flags { get; set; }

        /// <summary>
        /// ID3 FrameId frame type
        /// </summary>
        string FrameId { get; }
        #endregion

        #region Methods

        /// <summary>
        /// Load frame form binary data
        /// </summary>
        /// <param name="frame">binary frame representation</param>
        void Parse(byte[] frame);
        /// <summary>
        /// Save frame to binary data
        /// </summary>
        /// <returns>binary frame representation</returns>
        byte[] Make();
        #endregion
    }
}
