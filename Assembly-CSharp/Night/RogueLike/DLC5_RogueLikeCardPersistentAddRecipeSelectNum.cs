using System;
using DayScene.UI.RogueLike;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Night.RogueLike
{
	// Token: 0x02000060 RID: 96
	public class DLC5_RogueLikeCardPersistentAddRecipeSelectNum : RogueLikeCardPersistent
	{
		// Token: 0x06000B82 RID: 2946 RVA: 0x000C3C00 File Offset: 0x000C1E00
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentAddRecipeSelectNum()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddRecipeSelectNum>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.RogueLike", "DLC5_RogueLikeCardPersistentAddRecipeSelectNum");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddRecipeSelectNum>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeFieldInfoPtr_extraSelectNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddRecipeSelectNum>.NativeClassPtr, "extraSelectNum");
			DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddRecipeSelectNum>.NativeClassPtr, 100665207);
			DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeMethodInfoPtr_CardEffectAfterLoadAndSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddRecipeSelectNum>.NativeClassPtr, 100665208);
			DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeMethodInfoPtr_RemoveCard_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddRecipeSelectNum>.NativeClassPtr, 100665209);
			DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddRecipeSelectNum>.NativeClassPtr, 100665210);
			DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddRecipeSelectNum>.NativeClassPtr, 100665211);
			DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddRecipeSelectNum>.NativeClassPtr, 100665212);
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x000C3CBC File Offset: 0x000C1EBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41386, XrefRangeEnd = 41390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(persistentCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x000C3D44 File Offset: 0x000C1F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41390, XrefRangeEnd = 41392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeMethodInfoPtr_CardEffectAfterLoadAndSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x000C3DA4 File Offset: 0x000C1FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41392, XrefRangeEnd = 41394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeMethodInfoPtr_RemoveCard_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x000C3E04 File Offset: 0x000C2004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41394, XrefRangeEnd = 41396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(persistentCardInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x000C3E80 File Offset: 0x000C2080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41396, XrefRangeEnd = 41399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x000C3EF4 File Offset: 0x000C20F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentAddRecipeSelectNum() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddRecipeSelectNum>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00008371 File Offset: 0x00006571
		public DLC5_RogueLikeCardPersistentAddRecipeSelectNum(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x000C3F30 File Offset: 0x000C2130
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x0000837A File Offset: 0x0000657A
		public unsafe int extraSelectNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeFieldInfoPtr_extraSelectNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddRecipeSelectNum.NativeFieldInfoPtr_extraSelectNum)) = value;
			}
		}

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeFieldInfoPtr_extraSelectNum;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectAfterLoadAndSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCard_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
