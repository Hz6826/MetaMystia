using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000104 RID: 260
	[Serializable]
	public class RogueLikeCardInstance : Object
	{
		// Token: 0x06001CB8 RID: 7352 RVA: 0x000FE6F4 File Offset: 0x000FC8F4
		// Note: this type is marked as 'beforefieldinit'.
		static RogueLikeCardInstance()
		{
			Il2CppClassPointerStore<RogueLikeCardInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "RogueLikeCardInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RogueLikeCardInstance>.NativeClassPtr);
			RogueLikeCardInstance.NativeFieldInfoPtr_m_CardTypeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardInstance>.NativeClassPtr, "m_CardTypeId");
			RogueLikeCardInstance.NativeFieldInfoPtr_m_Rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RogueLikeCardInstance>.NativeClassPtr, "m_Rarity");
			RogueLikeCardInstance.NativeMethodInfoPtr_get_CardType_Public_get_CardType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardInstance>.NativeClassPtr, 100668469);
			RogueLikeCardInstance.NativeMethodInfoPtr__ctor_Public_Void_CardType_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RogueLikeCardInstance>.NativeClassPtr, 100668470);
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x000FE774 File Offset: 0x000FC974
		public unsafe RogueLikeCardBase.CardType CardType
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardInstance.NativeMethodInfoPtr_get_CardType_Public_get_CardType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x000FE7B0 File Offset: 0x000FC9B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 150, RefRangeEnd = 154, XrefRangeStart = 150, XrefRangeEnd = 154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RogueLikeCardInstance(RogueLikeCardBase.CardType cardType, RogueLikeCardBase.Rarity rarity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RogueLikeCardInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cardType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RogueLikeCardInstance.NativeMethodInfoPtr__ctor_Public_Void_CardType_Rarity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x000117C2 File Offset: 0x0000F9C2
		public RogueLikeCardInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x000FE808 File Offset: 0x000FCA08
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x000117CB File Offset: 0x0000F9CB
		public unsafe int m_CardTypeId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardInstance.NativeFieldInfoPtr_m_CardTypeId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardInstance.NativeFieldInfoPtr_m_CardTypeId)) = value;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x000FE830 File Offset: 0x000FCA30
		// (set) Token: 0x06001CBF RID: 7359 RVA: 0x000117E6 File Offset: 0x0000F9E6
		public unsafe RogueLikeCardBase.Rarity m_Rarity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardInstance.NativeFieldInfoPtr_m_Rarity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RogueLikeCardInstance.NativeFieldInfoPtr_m_Rarity)) = value;
			}
		}

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeFieldInfoPtr_m_CardTypeId;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeFieldInfoPtr_m_Rarity;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_get_CardType_Public_get_CardType_0;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CardType_Rarity_0;
	}
}
