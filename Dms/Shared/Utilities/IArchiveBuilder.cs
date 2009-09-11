// This file is part of re-vision (www.re-motion.org)
// Copyright (C) 2005-2009 rubicon informationstechnologie gmbh, www.rubicon.eu
// 
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License version 3.0 
// as published by the Free Software Foundation.
// 
// This program is distributed in the hope that it will be useful, 
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the 
// GNU Affero General Public License for more details.
// 
// You should have received a copy of the GNU Affero General Public License
// along with this program; if not, see http://www.gnu.org/licenses.
// 
// Additional permissions are listed in the file re-motion_exceptions.txt.
// 
using System;
using System.Collections.Generic;

namespace Remotion.Dms.Shared.Utilities
{
  /// <summary>
  /// The <see cref="IArchiveBuilder"/> declares an API for adding files to an archive and to return the archive as a stream.
  /// </summary>
  public interface IArchiveBuilder
  {
    void AddFile (string fileName);
    void Build (string archiveFileName, EventHandler<StreamCopyProgressEventArgs> progressHandler);
    List<string> Files { get; }
  }
}