using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace GameData.Profile
{
	// Token: 0x0200031E RID: 798
	public class PartnerInfo : PartnerInfoBase
	{
		// Token: 0x06005EAA RID: 24234 RVA: 0x001D921C File Offset: 0x001D741C
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfo()
		{
			Il2CppClassPointerStore<PartnerInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfo>.NativeClassPtr);
			PartnerInfo.NativeFieldInfoPtr_moveSpeedLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfo>.NativeClassPtr, "moveSpeedLiteral");
			PartnerInfo.NativeMethodInfoPtr_get_MoveSpeedLiteral_Public_get_Speed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfo>.NativeClassPtr, 100682749);
			PartnerInfo.NativeMethodInfoPtr_GetMoveSpeedText_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfo>.NativeClassPtr, 100682750);
			PartnerInfo.NativeMethodInfoPtr_GetWorkSpeedText_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfo>.NativeClassPtr, 100682751);
			PartnerInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfo>.NativeClassPtr, 100682752);
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06005EAB RID: 24235 RVA: 0x001D92B0 File Offset: 0x001D74B0
		public unsafe PartnerInfoBase.Speed MoveSpeedLiteral
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 47610, RefRangeEnd = 47613, XrefRangeStart = 47610, XrefRangeEnd = 47613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfo.NativeMethodInfoPtr_get_MoveSpeedLiteral_Public_get_Speed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x001D92EC File Offset: 0x001D74EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234775, XrefRangeEnd = 234776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetMoveSpeedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfo.NativeMethodInfoPtr_GetMoveSpeedText_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005EAD RID: 24237 RVA: 0x001D9330 File Offset: 0x001D7530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234776, XrefRangeEnd = 234777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetWorkSpeedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfo.NativeMethodInfoPtr_GetWorkSpeedText_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005EAE RID: 24238 RVA: 0x001D9374 File Offset: 0x001D7574
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x00033A45 File Offset: 0x00031C45
		public PartnerInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x06005EB0 RID: 24240 RVA: 0x001D93B0 File Offset: 0x001D75B0
		// (set) Token: 0x06005EB1 RID: 24241 RVA: 0x00033A4E File Offset: 0x00031C4E
		public unsafe PartnerInfoBase.Speed moveSpeedLiteral
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfo.NativeFieldInfoPtr_moveSpeedLiteral);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfo.NativeFieldInfoPtr_moveSpeedLiteral)) = value;
			}
		}

		// Token: 0x04003E9A RID: 16026
		private static readonly IntPtr NativeFieldInfoPtr_moveSpeedLiteral;

		// Token: 0x04003E9B RID: 16027
		private static readonly IntPtr NativeMethodInfoPtr_get_MoveSpeedLiteral_Public_get_Speed_0;

		// Token: 0x04003E9C RID: 16028
		private static readonly IntPtr NativeMethodInfoPtr_GetMoveSpeedText_Protected_Virtual_String_0;

		// Token: 0x04003E9D RID: 16029
		private static readonly IntPtr NativeMethodInfoPtr_GetWorkSpeedText_Protected_Virtual_String_0;

		// Token: 0x04003E9E RID: 16030
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
