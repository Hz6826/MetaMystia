using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002E9 RID: 745
	public class RecordProfile : ScriptableObject
	{
		// Token: 0x06005A14 RID: 23060 RVA: 0x001CC71C File Offset: 0x001CA91C
		// Note: this type is marked as 'beforefieldinit'.
		static RecordProfile()
		{
			Il2CppClassPointerStore<RecordProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "RecordProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecordProfile>.NativeClassPtr);
			RecordProfile.NativeFieldInfoPtr_records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecordProfile>.NativeClassPtr, "records");
			RecordProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecordProfile>.NativeClassPtr, 100681404);
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x001CC774 File Offset: 0x001CA974
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecordProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecordProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecordProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x00030A5D File Offset: 0x0002EC5D
		public RecordProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x06005A17 RID: 23063 RVA: 0x001CC7B0 File Offset: 0x001CA9B0
		// (set) Token: 0x06005A18 RID: 23064 RVA: 0x00030A66 File Offset: 0x0002EC66
		public unsafe Il2CppReferenceArray<Record> records
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordProfile.NativeFieldInfoPtr_records);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Record>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecordProfile.NativeFieldInfoPtr_records), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C04 RID: 15364
		private static readonly IntPtr NativeFieldInfoPtr_records;

		// Token: 0x04003C05 RID: 15365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
