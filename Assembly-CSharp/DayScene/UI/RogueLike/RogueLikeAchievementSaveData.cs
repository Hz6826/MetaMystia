using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000136 RID: 310
	[Serializable]
	public sealed class RogueLikeAchievementSaveData : ValueType
	{
		// Token: 0x06002575 RID: 9589 RVA: 0x0011C384 File Offset: 0x0011A584
		// Note: this type is marked as 'beforefieldinit'.
		static RogueLikeAchievementSaveData()
		{
			Il2CppClassPointerStore<RogueLikeAchievementSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RogueLikeAchievementSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeAchievementSaveData>.NativeClassPtr);
			RogueLikeAchievementSaveData.NativeFieldInfoPtr_realSaveTimeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementSaveData>.NativeClassPtr, "realSaveTimeCode");
			RogueLikeAchievementSaveData.NativeFieldInfoPtr__ActiveAchievementTypes_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeAchievementSaveData>.NativeClassPtr, "<ActiveAchievementTypes>k__BackingField");
			RogueLikeAchievementSaveData.NativeMethodInfoPtr_get_ActiveAchievementTypes_Public_get_HashSet_1_RogueLikeAchievementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementSaveData>.NativeClassPtr, 100669984);
			RogueLikeAchievementSaveData.NativeMethodInfoPtr_get_RealSaveTimeCode_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementSaveData>.NativeClassPtr, 100669985);
			RogueLikeAchievementSaveData.NativeMethodInfoPtr__ctor_Public_Void_DateTime_HashSet_1_RogueLikeAchievementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementSaveData>.NativeClassPtr, 100669986);
			RogueLikeAchievementSaveData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RogueLikeAchievementSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeAchievementSaveData>.NativeClassPtr, 100669987);
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x0011C42C File Offset: 0x0011A62C
		public unsafe HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> ActiveAchievementTypes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementSaveData.NativeMethodInfoPtr_get_ActiveAchievementTypes_Public_get_HashSet_1_RogueLikeAchievementType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType>>(intPtr3) : null;
			}
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x0011C470 File Offset: 0x0011A670
		public unsafe DateTime RealSaveTimeCode
		{
			[CallerCount(96)]
			[CachedScanResults(RefRangeStart = 2638, RefRangeEnd = 2734, XrefRangeStart = 2638, XrefRangeEnd = 2734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementSaveData.NativeMethodInfoPtr_get_RealSaveTimeCode_Public_get_DateTime_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x0011C4B4 File Offset: 0x0011A6B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88611, XrefRangeEnd = 88615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RogueLikeAchievementSaveData(DateTime realSaveTimeCode, HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> activeAchievementTypes) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeAchievementSaveData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref realSaveTimeCode;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeAchievementTypes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementSaveData.NativeMethodInfoPtr__ctor_Public_Void_DateTime_HashSet_1_RogueLikeAchievementType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x0011C514 File Offset: 0x0011A714
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88625, RefRangeEnd = 88626, XrefRangeStart = 88615, XrefRangeEnd = 88625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RogueLikeAchievementSaveData Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(RogueLikeAchievementSaveData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RogueLikeAchievementSaveData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new RogueLikeAchievementSaveData(pointer);
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x00016396 File Offset: 0x00014596
		public RogueLikeAchievementSaveData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x0001639F File Offset: 0x0001459F
		public RogueLikeAchievementSaveData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeAchievementSaveData>.NativeClassPtr))
		{
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x0011C550 File Offset: 0x0011A750
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x000163B1 File Offset: 0x000145B1
		public unsafe DateTime realSaveTimeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementSaveData.NativeFieldInfoPtr_realSaveTimeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementSaveData.NativeFieldInfoPtr_realSaveTimeCode)) = value;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x0011C578 File Offset: 0x0011A778
		// (set) Token: 0x0600257F RID: 9599 RVA: 0x000163CC File Offset: 0x000145CC
		public unsafe HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> _ActiveAchievementTypes_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementSaveData.NativeFieldInfoPtr__ActiveAchievementTypes_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeAchievementSaveData.NativeFieldInfoPtr__ActiveAchievementTypes_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001913 RID: 6419
		private static readonly IntPtr NativeFieldInfoPtr_realSaveTimeCode;

		// Token: 0x04001914 RID: 6420
		private static readonly IntPtr NativeFieldInfoPtr__ActiveAchievementTypes_k__BackingField;

		// Token: 0x04001915 RID: 6421
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveAchievementTypes_Public_get_HashSet_1_RogueLikeAchievementType_0;

		// Token: 0x04001916 RID: 6422
		private static readonly IntPtr NativeMethodInfoPtr_get_RealSaveTimeCode_Public_get_DateTime_0;

		// Token: 0x04001917 RID: 6423
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DateTime_HashSet_1_RogueLikeAchievementType_0;

		// Token: 0x04001918 RID: 6424
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RogueLikeAchievementSaveData_0;
	}
}
