// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Changed Paper external sharing setting to anyone.</para>
    /// </summary>
    public class PaperExternalViewAllowDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PaperExternalViewAllowDetails> Encoder = new PaperExternalViewAllowDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PaperExternalViewAllowDetails> Decoder = new PaperExternalViewAllowDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperExternalViewAllowDetails"
        /// /> class.</para>
        /// </summary>
        /// <param name="eventUuid">Event unique identifier.</param>
        public PaperExternalViewAllowDetails(string eventUuid)
        {
            if (eventUuid == null)
            {
                throw new sys.ArgumentNullException("eventUuid");
            }

            this.EventUuid = eventUuid;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PaperExternalViewAllowDetails"
        /// /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public PaperExternalViewAllowDetails()
        {
        }

        /// <summary>
        /// <para>Event unique identifier.</para>
        /// </summary>
        public string EventUuid { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PaperExternalViewAllowDetails" />.</para>
        /// </summary>
        private class PaperExternalViewAllowDetailsEncoder : enc.StructEncoder<PaperExternalViewAllowDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PaperExternalViewAllowDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("event_uuid", value.EventUuid, writer, enc.StringEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PaperExternalViewAllowDetails" />.</para>
        /// </summary>
        private class PaperExternalViewAllowDetailsDecoder : enc.StructDecoder<PaperExternalViewAllowDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PaperExternalViewAllowDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PaperExternalViewAllowDetails Create()
            {
                return new PaperExternalViewAllowDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(PaperExternalViewAllowDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "event_uuid":
                        value.EventUuid = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
