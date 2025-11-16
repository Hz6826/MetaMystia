using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameData.Profile
{
	// Token: 0x020002CE RID: 718
	[Serializable]
	public class VisualIdPair : Object
	{
		// Token: 0x0600588A RID: 22666 RVA: 0x001C8C94 File Offset: 0x001C6E94
		// Note: this type is marked as 'beforefieldinit'.
		static VisualIdPair()
		{
			Il2CppClassPointerStore<VisualIdPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "VisualIdPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualIdPair>.NativeClassPtr);
			VisualIdPair.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualIdPair>.NativeClassPtr, "id");
			VisualIdPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualIdPair>.NativeClassPtr, 100681267);
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x001C8CEC File Offset: 0x001C6EEC
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualIdPair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualIdPair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualIdPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x0002F76C File Offset: 0x0002D96C
		public VisualIdPair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x0600588D RID: 22669 RVA: 0x001C8D28 File Offset: 0x001C6F28
		// (set) Token: 0x0600588E RID: 22670 RVA: 0x0002F775 File Offset: 0x0002D975
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualIdPair.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualIdPair.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x04003B45 RID: 15173
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x04003B46 RID: 15174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
