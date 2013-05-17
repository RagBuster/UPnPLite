﻿
namespace SV.UPnPLite.Protocols.DLNA
{
    /// <summary>
    ///     Defines an errors that could be generated by a MediaServer.
    /// </summary>
    public enum MediaServerError
    {
        /// <summary>
        ///     An enexpected error occurred on MediaServer. Ussually it means that MediaServer returned an error which is not defined in UPnP/DLNA protocol.
        /// </summary>
        UnexpectedError = 0,

        /// <summary>
        ///     The specified ObjectID is invalid. 
        /// </summary>
        NoSuchObject = 701,

        /// <summary>
        ///     The tag/value pair(s) listed in CurrentTagValue do not match the current state of the CDS.  The specified data is likely out of date.
        /// </summary>
        InvalidCurrentTagValue = 702,

        /// <summary>
        ///     The specified value for the NewTagValue parameter is invalid.
        /// </summary>
        InvalidNewTagValue = 703,

        /// <summary>
        ///     Unable to delete a required tag.
        /// </summary>
        RequiredTag = 704,

        /// <summary>
        ///     Unable to update a read only tag.
        /// </summary>
        ReadOnlyTag = 705,

        /// <summary>
        ///     The number of tag/value pairs (including empty placeholders) in CurrentTagValue and NewTagValue do not match.
        /// </summary>
        ParameterMismatch = 706,

        /// <summary>
        ///     The search criteria specified is not supported or is invalid.
        /// </summary>
        SearchCriteria = 708,

        /// <summary>
        ///     The sort criteria specified is not supported or is invalid.
        /// </summary>
        SortCriteria = 709,

        /// <summary>
        ///     The specified ContainerID is invalid or identifies an object that is not a container. 
        /// </summary>
        NoSuchContainer = 710,

        /// <summary>
        ///     Operation failed because restricted attribute of object is set to true.
        /// </summary>
        RestrictedObject = 711,

        /// <summary>
        ///     Cannot create object in the specified container with the specified meta-data.
        /// </summary>
        BadMetadata = 712,

        /// <summary>
        ///     Create object failed because restricted attribute of parent container is set to true. 
        /// </summary>
        RestrictedParentObject = 713,

        /// <summary>
        ///     Cannot identify the specified source resource.
        /// </summary>
        NoSuchSourceResource = 714,

        /// <summary>
        ///     Cannot access the local resource.
        /// </summary>
        ResourceAccessDenied = 715,

        /// <summary>
        ///     Another file transfer is not accepted.
        /// </summary>
        TransferBusy = 716,

        /// <summary>
        ///     The file transfer specified by TransferID does not exist.
        /// </summary>
        NoSuchFileTransfer = 717,

        /// <summary>
        ///     Cannot identify the specified destination resource.
        /// </summary>
        NoSuchDestinationResource = 718,

        /// <summary>
        ///     Cannot access the specified destination resource.
        /// </summary>
        DestinationResourceAccessDenied = 719,

        /// <summary>
        ///     Cannot process the request.
        /// </summary>
        CannotProcessRequest = 720
    }
}