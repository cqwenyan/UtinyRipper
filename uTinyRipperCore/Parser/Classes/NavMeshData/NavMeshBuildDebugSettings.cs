﻿using uTinyRipper.AssetExporters;
using uTinyRipper.Exporter.YAML;

namespace uTinyRipper.Classes.NavMeshDatas
{
	public struct NavMeshBuildDebugSettings : IAssetReadable, IYAMLExportable
	{
		public void Read(AssetReader reader)
		{
			Flags = reader.ReadByte();
			reader.AlignStream(AlignType.Align4);
		}

		public YAMLNode ExportYAML(IExportContainer container)
		{
			YAMLMappingNode node = new YAMLMappingNode();
			node.Add("m_Flags", Flags);
			return node;
		}

		public byte Flags { get; private set; }
	}
}
