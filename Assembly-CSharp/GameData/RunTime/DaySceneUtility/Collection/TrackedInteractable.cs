using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.RunTime.DaySceneUtility.Collection
{
	// Token: 0x02000224 RID: 548
	[Serializable]
	public class TrackedInteractable : Object
	{
		// Token: 0x0600415D RID: 16733 RVA: 0x0017E3DC File Offset: 0x0017C5DC
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedInteractable()
		{
			Il2CppClassPointerStore<TrackedInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.DaySceneUtility.Collection", "TrackedInteractable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedInteractable>.NativeClassPtr);
			TrackedInteractable.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedInteractable>.NativeClassPtr, "label");
			TrackedInteractable.NativeFieldInfoPtr_openStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedInteractable>.NativeClassPtr, "openStatus");
			TrackedInteractable.NativeFieldInfoPtr_trackedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedInteractable>.NativeClassPtr, "trackedTime");
			TrackedInteractable.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedInteractable>.NativeClassPtr, 100675649);
			TrackedInteractable.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedInteractable>.NativeClassPtr, 100675650);
			TrackedInteractable.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_TrackedInteractable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedInteractable>.NativeClassPtr, 100675651);
		}

		// Token: 0x0600415E RID: 16734 RVA: 0x0017E484 File Offset: 0x0017C684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161119, XrefRangeEnd = 161121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedInteractable(string label) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedInteractable>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedInteractable.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600415F RID: 16735 RVA: 0x0017E4D0 File Offset: 0x0017C6D0
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedInteractable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedInteractable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedInteractable.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004160 RID: 16736 RVA: 0x0017E50C File Offset: 0x0017C70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161121, XrefRangeEnd = 161135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TrackedInteractable Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedInteractable.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_TrackedInteractable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TrackedInteractable>(intPtr3) : null;
		}

		// Token: 0x06004161 RID: 16737 RVA: 0x000236B6 File Offset: 0x000218B6
		public TrackedInteractable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x06004162 RID: 16738 RVA: 0x0017E54C File Offset: 0x0017C74C
		// (set) Token: 0x06004163 RID: 16739 RVA: 0x000236BF File Offset: 0x000218BF
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedInteractable.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedInteractable.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001612 RID: 5650
		// (get) Token: 0x06004164 RID: 16740 RVA: 0x0017E574 File Offset: 0x0017C774
		// (set) Token: 0x06004165 RID: 16741 RVA: 0x000236DE File Offset: 0x000218DE
		public unsafe bool openStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedInteractable.NativeFieldInfoPtr_openStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedInteractable.NativeFieldInfoPtr_openStatus)) = value;
			}
		}

		// Token: 0x17001613 RID: 5651
		// (get) Token: 0x06004166 RID: 16742 RVA: 0x0017E59C File Offset: 0x0017C79C
		// (set) Token: 0x06004167 RID: 16743 RVA: 0x000236F9 File Offset: 0x000218F9
		public unsafe int trackedTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedInteractable.NativeFieldInfoPtr_trackedTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedInteractable.NativeFieldInfoPtr_trackedTime)) = value;
			}
		}

		// Token: 0x04002C0B RID: 11275
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04002C0C RID: 11276
		private static readonly IntPtr NativeFieldInfoPtr_openStatus;

		// Token: 0x04002C0D RID: 11277
		private static readonly IntPtr NativeFieldInfoPtr_trackedTime;

		// Token: 0x04002C0E RID: 11278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002C0F RID: 11279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04002C10 RID: 11280
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_TrackedInteractable_0;
	}
}
