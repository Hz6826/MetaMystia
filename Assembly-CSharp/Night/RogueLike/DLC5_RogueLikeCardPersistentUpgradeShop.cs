using System;
using DayScene.UI.RogueLike;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Night.RogueLike
{
	// Token: 0x0200006F RID: 111
	public class DLC5_RogueLikeCardPersistentUpgradeShop : RogueLikeCardPersistent
	{
		// Token: 0x06000C19 RID: 3097 RVA: 0x000C676C File Offset: 0x000C496C
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentUpgradeShop()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentUpgradeShop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.RogueLike", "DLC5_RogueLikeCardPersistentUpgradeShop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentUpgradeShop>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentUpgradeShop.NativeMethodInfoPtr_AfterInitialize_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentUpgradeShop>.NativeClassPtr, 100665345);
			DLC5_RogueLikeCardPersistentUpgradeShop.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentUpgradeShop>.NativeClassPtr, 100665346);
			DLC5_RogueLikeCardPersistentUpgradeShop.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentUpgradeShop>.NativeClassPtr, 100665347);
			DLC5_RogueLikeCardPersistentUpgradeShop.NativeMethodInfoPtr_GetDescriptionInAlbum_Public_Virtual_String_String_RogueLikeRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentUpgradeShop>.NativeClassPtr, 100665348);
			DLC5_RogueLikeCardPersistentUpgradeShop.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentUpgradeShop>.NativeClassPtr, 100665349);
			DLC5_RogueLikeCardPersistentUpgradeShop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentUpgradeShop>.NativeClassPtr, 100665350);
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x000C6814 File Offset: 0x000C4A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42689, XrefRangeEnd = 42736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterInitialize(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentUpgradeShop.NativeMethodInfoPtr_AfterInitialize_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x000C6874 File Offset: 0x000C4A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42736, XrefRangeEnd = 42739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(persistentCardInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentUpgradeShop.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x000C68F0 File Offset: 0x000C4AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42739, XrefRangeEnd = 42766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(persistentCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentUpgradeShop.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x000C6978 File Offset: 0x000C4B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42766, XrefRangeEnd = 42769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetDescriptionInAlbum(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentUpgradeShop.NativeMethodInfoPtr_GetDescriptionInAlbum_Public_Virtual_String_String_RogueLikeRunTimeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x000C69E0 File Offset: 0x000C4BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42769, XrefRangeEnd = 42809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentUpgradeShop.NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x000C6A40 File Offset: 0x000C4C40
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentUpgradeShop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentUpgradeShop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentUpgradeShop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0000869B File Offset: 0x0000689B
		public DLC5_RogueLikeCardPersistentUpgradeShop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_AfterInitialize_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeRunTimeData_RogueLikePersistentCardInstance_RogueLikeManager_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_GetDescriptionInAlbum_Public_Virtual_String_String_RogueLikeRunTimeData_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_AfterSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
