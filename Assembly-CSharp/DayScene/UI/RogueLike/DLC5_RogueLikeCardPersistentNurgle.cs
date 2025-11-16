using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Night.RogueLike;
using NightScene.EventUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000F4 RID: 244
	public class DLC5_RogueLikeCardPersistentNurgle : RogueLikeCardPersistent
	{
		// Token: 0x06001B47 RID: 6983 RVA: 0x000F9D28 File Offset: 0x000F7F28
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardPersistentNurgle()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentNurgle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardPersistentNurgle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentNurgle>.NativeClassPtr);
			DLC5_RogueLikeCardPersistentNurgle.NativeFieldInfoPtr_decreaseOrderRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentNurgle>.NativeClassPtr, "decreaseOrderRate");
			DLC5_RogueLikeCardPersistentNurgle.NativeFieldInfoPtr_extraIngSoldNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentNurgle>.NativeClassPtr, "extraIngSoldNum");
			DLC5_RogueLikeCardPersistentNurgle.NativeMethodInfoPtr_CardEffectAfterLoadAndSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentNurgle>.NativeClassPtr, 100668233);
			DLC5_RogueLikeCardPersistentNurgle.NativeMethodInfoPtr_RemoveCard_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentNurgle>.NativeClassPtr, 100668234);
			DLC5_RogueLikeCardPersistentNurgle.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentNurgle>.NativeClassPtr, 100668235);
			DLC5_RogueLikeCardPersistentNurgle.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentNurgle>.NativeClassPtr, 100668236);
			DLC5_RogueLikeCardPersistentNurgle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentNurgle>.NativeClassPtr, 100668237);
			DLC5_RogueLikeCardPersistentNurgle.NativeMethodInfoPtr__CardEffectBeforeWorking_b__4_0_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentNurgle>.NativeClassPtr, 100668238);
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x000F9DF8 File Offset: 0x000F7FF8
		[CallerCount(0)]
		public unsafe override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentNurgle.NativeMethodInfoPtr_CardEffectAfterLoadAndSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x000F9E58 File Offset: 0x000F8058
		[CallerCount(0)]
		public unsafe override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentNurgle.NativeMethodInfoPtr_RemoveCard_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x000F9EB8 File Offset: 0x000F80B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72081, XrefRangeEnd = 72097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentNurgle.NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x000F9F38 File Offset: 0x000F8138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72097, XrefRangeEnd = 72107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeCardInstance);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cardNum;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardPersistentNurgle.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x000F9FC0 File Offset: 0x000F81C0
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardPersistentNurgle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardPersistentNurgle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentNurgle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x000F9FFC File Offset: 0x000F81FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 72107, XrefRangeEnd = 72112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _CardEffectBeforeWorking_b__4_0(string x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardPersistentNurgle.NativeMethodInfoPtr__CardEffectBeforeWorking_b__4_0_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00010AF6 File Offset: 0x0000ECF6
		public DLC5_RogueLikeCardPersistentNurgle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001B4F RID: 6991 RVA: 0x000FA044 File Offset: 0x000F8244
		// (set) Token: 0x06001B50 RID: 6992 RVA: 0x00010AFF File Offset: 0x0000ECFF
		public unsafe float decreaseOrderRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentNurgle.NativeFieldInfoPtr_decreaseOrderRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentNurgle.NativeFieldInfoPtr_decreaseOrderRate)) = value;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x000FA06C File Offset: 0x000F826C
		// (set) Token: 0x06001B52 RID: 6994 RVA: 0x00010B1A File Offset: 0x0000ED1A
		public unsafe float extraIngSoldNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentNurgle.NativeFieldInfoPtr_extraIngSoldNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardPersistentNurgle.NativeFieldInfoPtr_extraIngSoldNum)) = value;
			}
		}

		// Token: 0x0400122C RID: 4652
		private static readonly IntPtr NativeFieldInfoPtr_decreaseOrderRate;

		// Token: 0x0400122D RID: 4653
		private static readonly IntPtr NativeFieldInfoPtr_extraIngSoldNum;

		// Token: 0x0400122E RID: 4654
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectAfterLoadAndSelect_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x0400122F RID: 4655
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCard_Public_Virtual_Void_RogueLikeRunTimeData_RogueLikePersistentCardInstance_0;

		// Token: 0x04001230 RID: 4656
		private static readonly IntPtr NativeMethodInfoPtr_CardEffectBeforeWorking_Public_Virtual_Void_RogueLikeManager_EventManager_Int32_RogueLikePersistentCardInstance_0;

		// Token: 0x04001231 RID: 4657
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_RogueLikeRunTimeData_RogueLikePersistentCardInstance_Int32_0;

		// Token: 0x04001232 RID: 4658
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001233 RID: 4659
		private static readonly IntPtr NativeMethodInfoPtr__CardEffectBeforeWorking_b__4_0_Private_String_String_0;
	}
}
