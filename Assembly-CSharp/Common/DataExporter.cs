using System;
using DEYU.Singletons;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Common
{
	// Token: 0x0200033C RID: 828
	public class DataExporter : MonoSingletonPersistant<DataExporter>
	{
		// Token: 0x06006297 RID: 25239 RVA: 0x001E7F38 File Offset: 0x001E6138
		// Note: this type is marked as 'beforefieldinit'.
		static DataExporter()
		{
			Il2CppClassPointerStore<DataExporter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common", "DataExporter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataExporter>.NativeClassPtr);
			DataExporter.NativeFieldInfoPtr_inputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataExporter>.NativeClassPtr, "inputAction");
			DataExporter.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporter>.NativeClassPtr, 100684042);
			DataExporter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataExporter>.NativeClassPtr, 100684043);
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x001E7FA4 File Offset: 0x001E61A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255165, RefRangeEnd = 255166, XrefRangeStart = 255142, XrefRangeEnd = 255165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporter.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x001E7FD8 File Offset: 0x001E61D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255166, XrefRangeEnd = 255169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DataExporter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DataExporter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataExporter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x00035476 File Offset: 0x00033676
		public DataExporter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021E9 RID: 8681
		// (get) Token: 0x0600629B RID: 25243 RVA: 0x001E8014 File Offset: 0x001E6214
		// (set) Token: 0x0600629C RID: 25244 RVA: 0x0003547F File Offset: 0x0003367F
		public unsafe DataExporterInput inputAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporter.NativeFieldInfoPtr_inputAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataExporterInput>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataExporter.NativeFieldInfoPtr_inputAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400415A RID: 16730
		private static readonly IntPtr NativeFieldInfoPtr_inputAction;

		// Token: 0x0400415B RID: 16731
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x0400415C RID: 16732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
