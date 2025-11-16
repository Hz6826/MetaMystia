using System;
using DayScene.UI.RogueLike;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Night.RogueLike
{
	// Token: 0x0200005A RID: 90
	public class DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe : RogueLikeCardPersistent
	{
		// Token: 0x06000B4A RID: 2890 RVA: 0x000C29B8 File Offset: 0x000C0BB8
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.RogueLike", "DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe.NativeFieldInfoPtr_addFreeIngredientFromRecipeNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe>.NativeClassPtr, "addFreeIngredientFromRecipeNum");
			DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe>.NativeClassPtr, 100665155);
			DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe.NativeMethodInfoPtr_CardEffectAfterLoadAndSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe>.NativeClassPtr, 100665156);
			DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe.NativeMethodInfoPtr_RemoveCard_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe>.NativeClassPtr, 100665157);
			DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe.NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe>.NativeClassPtr, 100665158);
			DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe>.NativeClassPtr, 100665159);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x000C2A60 File Offset: 0x000C0C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40789, XrefRangeEnd = 40794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(persistentCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x000C2AE8 File Offset: 0x000C0CE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40794, XrefRangeEnd = 40796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe.NativeMethodInfoPtr_CardEffectAfterLoadAndSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x000C2B48 File Offset: 0x000C0D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40796, XrefRangeEnd = 40798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe.NativeMethodInfoPtr_RemoveCard_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x000C2BA8 File Offset: 0x000C0DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40798, XrefRangeEnd = 40801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref num;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe.NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x000C2C1C File Offset: 0x000C0E1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000082A6 File Offset: 0x000064A6
		public DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x000C2C58 File Offset: 0x000C0E58
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x000082AF File Offset: 0x000064AF
		public unsafe int addFreeIngredientFromRecipeNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe.NativeFieldInfoPtr_addFreeIngredientFromRecipeNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentAddFreeIngredientFromRecipe.NativeFieldInfoPtr_addFreeIngredientFromRecipeNum)) = value;
			}
		}

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeFieldInfoPtr_addFreeIngredientFromRecipeNum;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectAfterLoadAndSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCard_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffValueDescription_Public_Virtual_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
