using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace NightScene.UI.CookingUtility
{
	// Token: 0x020001D4 RID: 468
	public class CookingStatusModule : MonoBehaviour
	{
		// Token: 0x06003AAA RID: 15018 RVA: 0x00166888 File Offset: 0x00164A88
		// Note: this type is marked as 'beforefieldinit'.
		static CookingStatusModule()
		{
			Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.CookingUtility", "CookingStatusModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr);
			CookingStatusModule.NativeFieldInfoPtr_indicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, "indicator");
			CookingStatusModule.NativeFieldInfoPtr_body = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, "body");
			CookingStatusModule.NativeFieldInfoPtr_transitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, "transitionDuration");
			CookingStatusModule.NativeFieldInfoPtr_cooking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, "cooking");
			CookingStatusModule.NativeFieldInfoPtr_finishCook = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, "finishCook");
			CookingStatusModule.NativeFieldInfoPtr_m_SizeMinMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, "m_SizeMinMax");
			CookingStatusModule.NativeMethodInfoPtr_set_BarSprite_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, 100674209);
			CookingStatusModule.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, 100674210);
			CookingStatusModule.NativeMethodInfoPtr_SetProgress_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, 100674211);
			CookingStatusModule.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, 100674212);
			CookingStatusModule.NativeMethodInfoPtr_Finish_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, 100674213);
			CookingStatusModule.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, 100674214);
			CookingStatusModule.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, 100674215);
			CookingStatusModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr, 100674216);
		}

		// Token: 0x17001438 RID: 5176
		// (set) Token: 0x06003AAB RID: 15019 RVA: 0x001669D0 File Offset: 0x00164BD0
		public unsafe Sprite BarSprite
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133343, XrefRangeEnd = 133345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookingStatusModule.NativeMethodInfoPtr_set_BarSprite_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003AAC RID: 15020 RVA: 0x00166A14 File Offset: 0x00164C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133345, XrefRangeEnd = 133357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookingStatusModule.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x00166A48 File Offset: 0x00164C48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 133361, RefRangeEnd = 133364, XrefRangeStart = 133357, XrefRangeEnd = 133361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookingStatusModule.NativeMethodInfoPtr_SetProgress_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x00166A88 File Offset: 0x00164C88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133372, RefRangeEnd = 133374, XrefRangeStart = 133364, XrefRangeEnd = 133372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookingStatusModule.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x00166ABC File Offset: 0x00164CBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 133376, RefRangeEnd = 133377, XrefRangeStart = 133374, XrefRangeEnd = 133376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookingStatusModule.NativeMethodInfoPtr_Finish_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x00166AF0 File Offset: 0x00164CF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 133384, RefRangeEnd = 133386, XrefRangeStart = 133377, XrefRangeEnd = 133384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookingStatusModule.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x00166B24 File Offset: 0x00164D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 133386, XrefRangeEnd = 133392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CookingStatusModule.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AB2 RID: 15026 RVA: 0x00166B60 File Offset: 0x00164D60
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookingStatusModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookingStatusModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookingStatusModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x00020DCC File Offset: 0x0001EFCC
		public CookingStatusModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001432 RID: 5170
		// (get) Token: 0x06003AB4 RID: 15028 RVA: 0x00166B9C File Offset: 0x00164D9C
		// (set) Token: 0x06003AB5 RID: 15029 RVA: 0x00020DD5 File Offset: 0x0001EFD5
		public unsafe SpriteRenderer indicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookingStatusModule.NativeFieldInfoPtr_indicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookingStatusModule.NativeFieldInfoPtr_indicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001433 RID: 5171
		// (get) Token: 0x06003AB6 RID: 15030 RVA: 0x00166BCC File Offset: 0x00164DCC
		// (set) Token: 0x06003AB7 RID: 15031 RVA: 0x00020DF4 File Offset: 0x0001EFF4
		public unsafe SpriteRenderer body
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookingStatusModule.NativeFieldInfoPtr_body);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookingStatusModule.NativeFieldInfoPtr_body), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x06003AB8 RID: 15032 RVA: 0x00166BFC File Offset: 0x00164DFC
		// (set) Token: 0x06003AB9 RID: 15033 RVA: 0x00020E13 File Offset: 0x0001F013
		public unsafe float transitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookingStatusModule.NativeFieldInfoPtr_transitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookingStatusModule.NativeFieldInfoPtr_transitionDuration)) = value;
			}
		}

		// Token: 0x17001435 RID: 5173
		// (get) Token: 0x06003ABA RID: 15034 RVA: 0x00166C24 File Offset: 0x00164E24
		// (set) Token: 0x06003ABB RID: 15035 RVA: 0x00020E2E File Offset: 0x0001F02E
		public unsafe Sprite cooking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookingStatusModule.NativeFieldInfoPtr_cooking);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookingStatusModule.NativeFieldInfoPtr_cooking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06003ABC RID: 15036 RVA: 0x00166C54 File Offset: 0x00164E54
		// (set) Token: 0x06003ABD RID: 15037 RVA: 0x00020E4D File Offset: 0x0001F04D
		public unsafe Sprite finishCook
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookingStatusModule.NativeFieldInfoPtr_finishCook);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookingStatusModule.NativeFieldInfoPtr_finishCook), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001437 RID: 5175
		// (get) Token: 0x06003ABE RID: 15038 RVA: 0x00166C84 File Offset: 0x00164E84
		// (set) Token: 0x06003ABF RID: 15039 RVA: 0x00020E6C File Offset: 0x0001F06C
		public unsafe Vector2 m_SizeMinMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookingStatusModule.NativeFieldInfoPtr_m_SizeMinMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookingStatusModule.NativeFieldInfoPtr_m_SizeMinMax)) = value;
			}
		}

		// Token: 0x04002771 RID: 10097
		private static readonly IntPtr NativeFieldInfoPtr_indicator;

		// Token: 0x04002772 RID: 10098
		private static readonly IntPtr NativeFieldInfoPtr_body;

		// Token: 0x04002773 RID: 10099
		private static readonly IntPtr NativeFieldInfoPtr_transitionDuration;

		// Token: 0x04002774 RID: 10100
		private static readonly IntPtr NativeFieldInfoPtr_cooking;

		// Token: 0x04002775 RID: 10101
		private static readonly IntPtr NativeFieldInfoPtr_finishCook;

		// Token: 0x04002776 RID: 10102
		private static readonly IntPtr NativeFieldInfoPtr_m_SizeMinMax;

		// Token: 0x04002777 RID: 10103
		private static readonly IntPtr NativeMethodInfoPtr_set_BarSprite_Private_set_Void_Sprite_0;

		// Token: 0x04002778 RID: 10104
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04002779 RID: 10105
		private static readonly IntPtr NativeMethodInfoPtr_SetProgress_Public_Void_Single_0;

		// Token: 0x0400277A RID: 10106
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_0;

		// Token: 0x0400277B RID: 10107
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Public_Void_0;

		// Token: 0x0400277C RID: 10108
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x0400277D RID: 10109
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x0400277E RID: 10110
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
