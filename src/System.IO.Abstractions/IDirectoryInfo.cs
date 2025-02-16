﻿using System.Collections.Generic;
using System.Security.AccessControl;

namespace System.IO.Abstractions
{
    /// <inheritdoc cref="DirectoryInfo" />
    public interface IDirectoryInfo : IFileSystemInfo
    {
        /// <inheritdoc cref="DirectoryInfo.Create()"/>
        void Create();

#if FEATURE_FILE_SYSTEM_ACL_EXTENSIONS
        /// <inheritdoc cref="FileSystemAclExtensions.Create(DirectoryInfo,DirectorySecurity)"/>
#else
        /// <inheritdoc cref="DirectoryInfo.Create(DirectorySecurity)"/>
#endif
        void Create(DirectorySecurity directorySecurity);
        /// <inheritdoc cref="DirectoryInfo.CreateSubdirectory(string)"/>
        IDirectoryInfo CreateSubdirectory(string path);
        /// <inheritdoc cref="DirectoryInfo.Delete(bool)"/>
        void Delete(bool recursive);
        /// <inheritdoc cref="DirectoryInfo.EnumerateDirectories()"/>
        IEnumerable<IDirectoryInfo> EnumerateDirectories();
        /// <inheritdoc cref="DirectoryInfo.EnumerateDirectories(string)"/>
        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern);
        /// <inheritdoc cref="DirectoryInfo.EnumerateDirectories(string,SearchOption)"/>
        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, SearchOption searchOption);

#if FEATURE_ENUMERATION_OPTIONS
        /// <inheritdoc cref="DirectoryInfo.EnumerateDirectories(string,EnumerationOptions)"/>
        IEnumerable<IDirectoryInfo> EnumerateDirectories(string searchPattern, EnumerationOptions enumerationOptions);
#endif

        /// <inheritdoc cref="DirectoryInfo.EnumerateFiles()"/>
        IEnumerable<IFileInfo> EnumerateFiles();
        /// <inheritdoc cref="DirectoryInfo.EnumerateFiles(string)"/>
        IEnumerable<IFileInfo> EnumerateFiles(string searchPattern);
        /// <inheritdoc cref="DirectoryInfo.EnumerateFiles(string,SearchOption)"/>
        IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, SearchOption searchOption);

#if FEATURE_ENUMERATION_OPTIONS
        /// <inheritdoc cref="DirectoryInfo.EnumerateFiles(string,EnumerationOptions)"/>
        IEnumerable<IFileInfo> EnumerateFiles(string searchPattern, EnumerationOptions enumerationOptions);
#endif

        /// <inheritdoc cref="DirectoryInfo.EnumerateFileSystemInfos()"/>
        IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos();
        /// <inheritdoc cref="DirectoryInfo.EnumerateFileSystemInfos(string)"/>
        IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern);
        /// <inheritdoc cref="DirectoryInfo.EnumerateFileSystemInfos(string,SearchOption)"/>
        IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, SearchOption searchOption);

#if FEATURE_ENUMERATION_OPTIONS
        /// <inheritdoc cref="DirectoryInfo.EnumerateFileSystemInfos(string,EnumerationOptions)"/>
        IEnumerable<IFileSystemInfo> EnumerateFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions);
#endif

#if FEATURE_FILE_SYSTEM_ACL_EXTENSIONS
        /// <inheritdoc cref="FileSystemAclExtensions.GetAccessControl(DirectoryInfo)"/>
#else
        /// <inheritdoc cref="DirectoryInfo.GetAccessControl()"/>
#endif
        DirectorySecurity GetAccessControl();

#if FEATURE_FILE_SYSTEM_ACL_EXTENSIONS
        /// <inheritdoc cref="FileSystemAclExtensions.GetAccessControl(DirectoryInfo,AccessControlSections)"/>
#else
        /// <inheritdoc cref="DirectoryInfo.GetAccessControl(AccessControlSections)"/>
#endif
        DirectorySecurity GetAccessControl(AccessControlSections includeSections);

        /// <inheritdoc cref="DirectoryInfo.GetDirectories()"/>
        IDirectoryInfo[] GetDirectories();
        /// <inheritdoc cref="DirectoryInfo.GetDirectories(string)"/>
        IDirectoryInfo[] GetDirectories(string searchPattern);
        /// <inheritdoc cref="DirectoryInfo.GetDirectories(string,SearchOption)"/>
        IDirectoryInfo[] GetDirectories(string searchPattern, SearchOption searchOption);

#if FEATURE_ENUMERATION_OPTIONS
        /// <inheritdoc cref="DirectoryInfo.GetDirectories(string,EnumerationOptions)"/>
        IDirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions);
#endif

        /// <inheritdoc cref="DirectoryInfo.GetFiles(string)"/>
        IFileInfo[] GetFiles();
        /// <inheritdoc cref="DirectoryInfo.GetFiles(string)"/>
        IFileInfo[] GetFiles(string searchPattern);
        /// <inheritdoc cref="DirectoryInfo.GetFiles(string,SearchOption)"/>
        IFileInfo[] GetFiles(string searchPattern, SearchOption searchOption);

#if FEATURE_ENUMERATION_OPTIONS
        /// <inheritdoc cref="DirectoryInfo.GetFiles(string,EnumerationOptions)"/>
        IFileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions);
#endif

        /// <inheritdoc cref="DirectoryInfo.GetFileSystemInfos()"/>
        IFileSystemInfo[] GetFileSystemInfos();
        /// <inheritdoc cref="DirectoryInfo.GetFileSystemInfos(string)"/>
        IFileSystemInfo[] GetFileSystemInfos(string searchPattern);
        /// <inheritdoc cref="DirectoryInfo.GetFileSystemInfos(string,SearchOption)"/>
        IFileSystemInfo[] GetFileSystemInfos(string searchPattern, SearchOption searchOption);

#if FEATURE_ENUMERATION_OPTIONS
        /// <inheritdoc cref="DirectoryInfo.GetFileSystemInfos(string,EnumerationOptions)"/>
        IFileSystemInfo[] GetFileSystemInfos(string searchPattern, EnumerationOptions enumerationOptions);
#endif

        /// <inheritdoc cref="DirectoryInfo.MoveTo"/>
        void MoveTo(string destDirName);


#if FEATURE_FILE_SYSTEM_ACL_EXTENSIONS
        /// <inheritdoc cref="FileSystemAclExtensions.SetAccessControl(DirectoryInfo,DirectorySecurity)"/>
#else
        /// <inheritdoc cref="DirectoryInfo.SetAccessControl(DirectorySecurity)"/>
#endif
        void SetAccessControl(DirectorySecurity directorySecurity);

        /// <inheritdoc cref="DirectoryInfo.Parent"/>
        IDirectoryInfo Parent { get; }
        /// <inheritdoc cref="DirectoryInfo.Root"/>
        IDirectoryInfo Root { get; }
    }
}