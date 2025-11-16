using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.UI.EventUtility;
using TMPro;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000311 RID: 785
	public class DLC2_DecorationSatoriEye : DecorationBase
	{
		// Token: 0x06005D38 RID: 23864 RVA: 0x001D4864 File Offset: 0x001D2A64
		// Note: this type is marked as 'beforefieldinit'.
		static DLC2_DecorationSatoriEye()
		{
			Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DLC2_DecorationSatoriEye");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr);
			DLC2_DecorationSatoriEye.NativeFieldInfoPtr_SATORI_EYE_BUFF_MARK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr, "SATORI_EYE_BUFF_MARK");
			DLC2_DecorationSatoriEye.NativeFieldInfoPtr_displayUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr, "displayUI");
			DLC2_DecorationSatoriEye.NativeFieldInfoPtr_UIFieldIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr, "UIFieldIndex");
			DLC2_DecorationSatoriEye.NativeFieldInfoPtr_UIOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr, "UIOffset");
			DLC2_DecorationSatoriEye.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr, 100682501);
			DLC2_DecorationSatoriEye.NativeMethodInfoPtr_SetNum_Private_Void_GuestGroupController_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr, 100682502);
			DLC2_DecorationSatoriEye.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr, 100682503);
		}

		// Token: 0x06005D39 RID: 23865 RVA: 0x001D4920 File Offset: 0x001D2B20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233119, XrefRangeEnd = 233161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DecorationBuffEnterNight(EventManager eventManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC2_DecorationSatoriEye.NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D3A RID: 23866 RVA: 0x001D4970 File Offset: 0x001D2B70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 233177, RefRangeEnd = 233178, XrefRangeStart = 233161, XrefRangeEnd = 233177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNum(GuestGroupController guestGroupController, GameObject targetDisplayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetDisplayer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.NativeMethodInfoPtr_SetNum_Private_Void_GuestGroupController_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D3B RID: 23867 RVA: 0x001D49C4 File Offset: 0x001D2BC4
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC2_DecorationSatoriEye() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D3C RID: 23868 RVA: 0x00032DD9 File Offset: 0x00030FD9
		public DLC2_DecorationSatoriEye(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x06005D3D RID: 23869 RVA: 0x001D4A00 File Offset: 0x001D2C00
		// (set) Token: 0x06005D3E RID: 23870 RVA: 0x00032DE2 File Offset: 0x00030FE2
		public unsafe static GuestBuffMarkModule.GuestBuffMark SATORI_EYE_BUFF_MARK
		{
			get
			{
				GuestBuffMarkModule.GuestBuffMark result;
				IL2CPP.il2cpp_field_static_get_value(DLC2_DecorationSatoriEye.NativeFieldInfoPtr_SATORI_EYE_BUFF_MARK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC2_DecorationSatoriEye.NativeFieldInfoPtr_SATORI_EYE_BUFF_MARK, (void*)(&value));
			}
		}

		// Token: 0x1700203D RID: 8253
		// (get) Token: 0x06005D3F RID: 23871 RVA: 0x001D4A1C File Offset: 0x001D2C1C
		// (set) Token: 0x06005D40 RID: 23872 RVA: 0x00032DF0 File Offset: 0x00030FF0
		public unsafe GameObject displayUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.NativeFieldInfoPtr_displayUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.NativeFieldInfoPtr_displayUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700203E RID: 8254
		// (get) Token: 0x06005D41 RID: 23873 RVA: 0x001D4A4C File Offset: 0x001D2C4C
		// (set) Token: 0x06005D42 RID: 23874 RVA: 0x00032E0F File Offset: 0x0003100F
		public unsafe int UIFieldIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.NativeFieldInfoPtr_UIFieldIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.NativeFieldInfoPtr_UIFieldIndex)) = value;
			}
		}

		// Token: 0x1700203F RID: 8255
		// (get) Token: 0x06005D43 RID: 23875 RVA: 0x001D4A74 File Offset: 0x001D2C74
		// (set) Token: 0x06005D44 RID: 23876 RVA: 0x00032E2A File Offset: 0x0003102A
		public unsafe float UIOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.NativeFieldInfoPtr_UIOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.NativeFieldInfoPtr_UIOffset)) = value;
			}
		}

		// Token: 0x04003DAF RID: 15791
		private static readonly IntPtr NativeFieldInfoPtr_SATORI_EYE_BUFF_MARK;

		// Token: 0x04003DB0 RID: 15792
		private static readonly IntPtr NativeFieldInfoPtr_displayUI;

		// Token: 0x04003DB1 RID: 15793
		private static readonly IntPtr NativeFieldInfoPtr_UIFieldIndex;

		// Token: 0x04003DB2 RID: 15794
		private static readonly IntPtr NativeFieldInfoPtr_UIOffset;

		// Token: 0x04003DB3 RID: 15795
		private static readonly IntPtr NativeMethodInfoPtr_DecorationBuffEnterNight_Public_Virtual_Void_EventManager_0;

		// Token: 0x04003DB4 RID: 15796
		private static readonly IntPtr NativeMethodInfoPtr_SetNum_Private_Void_GuestGroupController_GameObject_0;

		// Token: 0x04003DB5 RID: 15797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D2E RID: 3374
		[ObfuscatedName("GameData.Profile.DLC2_DecorationSatoriEye+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F30A RID: 62218 RVA: 0x00398F60 File Offset: 0x00397160
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_0>.NativeClassPtr);
				DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeFieldInfoPtr_onEndAllDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_0>.NativeClassPtr, "onEndAllDisplayer");
				DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeFieldInfoPtr_guestBuffMarkModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_0>.NativeClassPtr, "guestBuffMarkModule");
				DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
				DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_0>.NativeClassPtr, 100682504);
				DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_0>.NativeClassPtr, 100682505);
				DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_0>.NativeClassPtr, 100682506);
			}

			// Token: 0x0600F30B RID: 62219 RVA: 0x00399004 File Offset: 0x00397204
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F30C RID: 62220 RVA: 0x00399040 File Offset: 0x00397240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232912, XrefRangeEnd = 232944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController guestGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F30D RID: 62221 RVA: 0x00399084 File Offset: 0x00397284
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232944, XrefRangeEnd = 232954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F30E RID: 62222 RVA: 0x000827B1 File Offset: 0x000809B1
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F08 RID: 20232
			// (get) Token: 0x0600F30F RID: 62223 RVA: 0x003990B8 File Offset: 0x003972B8
			// (set) Token: 0x0600F310 RID: 62224 RVA: 0x000827BA File Offset: 0x000809BA
			public unsafe Action onEndAllDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeFieldInfoPtr_onEndAllDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeFieldInfoPtr_onEndAllDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F09 RID: 20233
			// (get) Token: 0x0600F311 RID: 62225 RVA: 0x003990E8 File Offset: 0x003972E8
			// (set) Token: 0x0600F312 RID: 62226 RVA: 0x000827D9 File Offset: 0x000809D9
			public unsafe GuestBuffMarkModule guestBuffMarkModule
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeFieldInfoPtr_guestBuffMarkModule);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestBuffMarkModule>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeFieldInfoPtr_guestBuffMarkModule), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F0A RID: 20234
			// (get) Token: 0x0600F313 RID: 62227 RVA: 0x00399118 File Offset: 0x00397318
			// (set) Token: 0x0600F314 RID: 62228 RVA: 0x000827F8 File Offset: 0x000809F8
			public unsafe DLC2_DecorationSatoriEye __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_DecorationSatoriEye>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AD3 RID: 39635
			private static readonly IntPtr NativeFieldInfoPtr_onEndAllDisplayer;

			// Token: 0x04009AD4 RID: 39636
			private static readonly IntPtr NativeFieldInfoPtr_guestBuffMarkModule;

			// Token: 0x04009AD5 RID: 39637
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009AD6 RID: 39638
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AD7 RID: 39639
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x04009AD8 RID: 39640
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000D2F RID: 3375
		[ObfuscatedName("GameData.Profile.DLC2_DecorationSatoriEye+<>c__DisplayClass4_1")]
		public sealed class __c__DisplayClass4_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F315 RID: 62229 RVA: 0x00399148 File Offset: 0x00397348
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_1()
			{
				Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr, "<>c__DisplayClass4_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_1>.NativeClassPtr);
				DLC2_DecorationSatoriEye.__c__DisplayClass4_1.NativeFieldInfoPtr_guestGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_1>.NativeClassPtr, "guestGroup");
				DLC2_DecorationSatoriEye.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_1>.NativeClassPtr, "CS$<>8__locals1");
				DLC2_DecorationSatoriEye.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_1>.NativeClassPtr, 100682507);
				DLC2_DecorationSatoriEye.__c__DisplayClass4_1.NativeMethodInfoPtr__DecorationBuffEnterNight_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_1>.NativeClassPtr, 100682508);
				DLC2_DecorationSatoriEye.__c__DisplayClass4_1.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_1>.NativeClassPtr, 100682509);
			}

			// Token: 0x0600F316 RID: 62230 RVA: 0x003991D8 File Offset: 0x003973D8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F317 RID: 62231 RVA: 0x00399214 File Offset: 0x00397414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232954, XrefRangeEnd = 232966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DecorationBuffEnterNight_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass4_1.NativeMethodInfoPtr__DecorationBuffEnterNight_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F318 RID: 62232 RVA: 0x00399248 File Offset: 0x00397448
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232966, XrefRangeEnd = 233029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass4_1.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F319 RID: 62233 RVA: 0x00082817 File Offset: 0x00080A17
			public __c__DisplayClass4_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F0B RID: 20235
			// (get) Token: 0x0600F31A RID: 62234 RVA: 0x0039928C File Offset: 0x0039748C
			// (set) Token: 0x0600F31B RID: 62235 RVA: 0x00082820 File Offset: 0x00080A20
			public unsafe GuestGroupController guestGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_1.NativeFieldInfoPtr_guestGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_1.NativeFieldInfoPtr_guestGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F0C RID: 20236
			// (get) Token: 0x0600F31C RID: 62236 RVA: 0x003992BC File Offset: 0x003974BC
			// (set) Token: 0x0600F31D RID: 62237 RVA: 0x0008283F File Offset: 0x00080A3F
			public unsafe DLC2_DecorationSatoriEye.__c__DisplayClass4_0 field_Public___c__DisplayClass4_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_DecorationSatoriEye.__c__DisplayClass4_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AD9 RID: 39641
			private static readonly IntPtr NativeFieldInfoPtr_guestGroup;

			// Token: 0x04009ADA RID: 39642
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0;

			// Token: 0x04009ADB RID: 39643
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009ADC RID: 39644
			private static readonly IntPtr NativeMethodInfoPtr__DecorationBuffEnterNight_b__3_Internal_Void_0;

			// Token: 0x04009ADD RID: 39645
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;
		}

		// Token: 0x02000D30 RID: 3376
		[ObfuscatedName("GameData.Profile.DLC2_DecorationSatoriEye+<>c__DisplayClass4_2")]
		public sealed class __c__DisplayClass4_2 : Il2CppSystem.Object
		{
			// Token: 0x0600F31E RID: 62238 RVA: 0x003992EC File Offset: 0x003974EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_2()
			{
				Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr, "<>c__DisplayClass4_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_2>.NativeClassPtr);
				DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeFieldInfoPtr_effectDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_2>.NativeClassPtr, "effectDisplayer");
				DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeFieldInfoPtr_field_Public___c__DisplayClass4_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_2>.NativeClassPtr, "CS$<>8__locals2");
				DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_2>.NativeClassPtr, 100682510);
				DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeMethodInfoPtr__DecorationBuffEnterNight_b__5_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_2>.NativeClassPtr, 100682511);
				DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_2>.NativeClassPtr, 100682512);
				DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_2>.NativeClassPtr, 100682513);
			}

			// Token: 0x0600F31F RID: 62239 RVA: 0x00399390 File Offset: 0x00397590
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F320 RID: 62240 RVA: 0x003993CC File Offset: 0x003975CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233029, XrefRangeEnd = 233047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DecorationBuffEnterNight_b__5(GameObject y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeMethodInfoPtr__DecorationBuffEnterNight_b__5_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F321 RID: 62241 RVA: 0x00399410 File Offset: 0x00397610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233047, XrefRangeEnd = 233052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController orderedGuest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderedGuest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F322 RID: 62242 RVA: 0x00399454 File Offset: 0x00397654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233052, XrefRangeEnd = 233082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F323 RID: 62243 RVA: 0x0008285E File Offset: 0x00080A5E
			public __c__DisplayClass4_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F0D RID: 20237
			// (get) Token: 0x0600F324 RID: 62244 RVA: 0x00399488 File Offset: 0x00397688
			// (set) Token: 0x0600F325 RID: 62245 RVA: 0x00082867 File Offset: 0x00080A67
			public unsafe GameObject effectDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeFieldInfoPtr_effectDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeFieldInfoPtr_effectDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F0E RID: 20238
			// (get) Token: 0x0600F326 RID: 62246 RVA: 0x003994B8 File Offset: 0x003976B8
			// (set) Token: 0x0600F327 RID: 62247 RVA: 0x00082886 File Offset: 0x00080A86
			public unsafe DLC2_DecorationSatoriEye.__c__DisplayClass4_1 field_Public___c__DisplayClass4_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeFieldInfoPtr_field_Public___c__DisplayClass4_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_DecorationSatoriEye.__c__DisplayClass4_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_2.NativeFieldInfoPtr_field_Public___c__DisplayClass4_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009ADE RID: 39646
			private static readonly IntPtr NativeFieldInfoPtr_effectDisplayer;

			// Token: 0x04009ADF RID: 39647
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass4_1_0;

			// Token: 0x04009AE0 RID: 39648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AE1 RID: 39649
			private static readonly IntPtr NativeMethodInfoPtr__DecorationBuffEnterNight_b__5_Internal_Void_GameObject_0;

			// Token: 0x04009AE2 RID: 39650
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x04009AE3 RID: 39651
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000D31 RID: 3377
		[ObfuscatedName("GameData.Profile.DLC2_DecorationSatoriEye+<>c__DisplayClass4_3")]
		public sealed class __c__DisplayClass4_3 : Il2CppSystem.Object
		{
			// Token: 0x0600F328 RID: 62248 RVA: 0x003994E8 File Offset: 0x003976E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_3()
			{
				Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr, "<>c__DisplayClass4_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_3>.NativeClassPtr);
				DLC2_DecorationSatoriEye.__c__DisplayClass4_3.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_3>.NativeClassPtr, "y");
				DLC2_DecorationSatoriEye.__c__DisplayClass4_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_3>.NativeClassPtr, 100682514);
				DLC2_DecorationSatoriEye.__c__DisplayClass4_3.NativeMethodInfoPtr__DecorationBuffEnterNight_b__9_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_3>.NativeClassPtr, 100682515);
			}

			// Token: 0x0600F329 RID: 62249 RVA: 0x00399550 File Offset: 0x00397750
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass4_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass4_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F32A RID: 62250 RVA: 0x0039958C File Offset: 0x0039778C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233082, XrefRangeEnd = 233086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DecorationBuffEnterNight_b__9()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass4_3.NativeMethodInfoPtr__DecorationBuffEnterNight_b__9_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F32B RID: 62251 RVA: 0x000828A5 File Offset: 0x00080AA5
			public __c__DisplayClass4_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F0F RID: 20239
			// (get) Token: 0x0600F32C RID: 62252 RVA: 0x003995C0 File Offset: 0x003977C0
			// (set) Token: 0x0600F32D RID: 62253 RVA: 0x000828AE File Offset: 0x00080AAE
			public unsafe GameObject y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_3.NativeFieldInfoPtr_y);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass4_3.NativeFieldInfoPtr_y), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AE4 RID: 39652
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04009AE5 RID: 39653
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AE6 RID: 39654
			private static readonly IntPtr NativeMethodInfoPtr__DecorationBuffEnterNight_b__9_Internal_Void_0;
		}

		// Token: 0x02000D32 RID: 3378
		[ObfuscatedName("GameData.Profile.DLC2_DecorationSatoriEye+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F32E RID: 62254 RVA: 0x003995F0 File Offset: 0x003977F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c>.NativeClassPtr);
				DLC2_DecorationSatoriEye.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c>.NativeClassPtr, "<>9");
				DLC2_DecorationSatoriEye.__c.NativeFieldInfoPtr___9__4_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c>.NativeClassPtr, "<>9__4_2");
				DLC2_DecorationSatoriEye.__c.NativeFieldInfoPtr___9__4_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c>.NativeClassPtr, "<>9__4_6");
				DLC2_DecorationSatoriEye.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c>.NativeClassPtr, 100682517);
				DLC2_DecorationSatoriEye.__c.NativeMethodInfoPtr__DecorationBuffEnterNight_b__4_2_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c>.NativeClassPtr, 100682518);
				DLC2_DecorationSatoriEye.__c.NativeMethodInfoPtr__DecorationBuffEnterNight_b__4_6_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c>.NativeClassPtr, 100682519);
			}

			// Token: 0x0600F32F RID: 62255 RVA: 0x00399694 File Offset: 0x00397894
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F330 RID: 62256 RVA: 0x003996D0 File Offset: 0x003978D0
			[CallerCount(0)]
			public unsafe string _DecorationBuffEnterNight_b__4_2(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c.NativeMethodInfoPtr__DecorationBuffEnterNight_b__4_2_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F331 RID: 62257 RVA: 0x00399718 File Offset: 0x00397918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233086, XrefRangeEnd = 233104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DecorationBuffEnterNight_b__4_6(GameObject y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c.NativeMethodInfoPtr__DecorationBuffEnterNight_b__4_6_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F332 RID: 62258 RVA: 0x000828CD File Offset: 0x00080ACD
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F10 RID: 20240
			// (get) Token: 0x0600F333 RID: 62259 RVA: 0x0039975C File Offset: 0x0039795C
			// (set) Token: 0x0600F334 RID: 62260 RVA: 0x000828D6 File Offset: 0x00080AD6
			public unsafe static DLC2_DecorationSatoriEye.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_DecorationSatoriEye.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_DecorationSatoriEye.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_DecorationSatoriEye.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F11 RID: 20241
			// (get) Token: 0x0600F335 RID: 62261 RVA: 0x00399784 File Offset: 0x00397984
			// (set) Token: 0x0600F336 RID: 62262 RVA: 0x000828E8 File Offset: 0x00080AE8
			public unsafe static Func<string, string> __9__4_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_DecorationSatoriEye.__c.NativeFieldInfoPtr___9__4_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_DecorationSatoriEye.__c.NativeFieldInfoPtr___9__4_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F12 RID: 20242
			// (get) Token: 0x0600F337 RID: 62263 RVA: 0x003997AC File Offset: 0x003979AC
			// (set) Token: 0x0600F338 RID: 62264 RVA: 0x000828FA File Offset: 0x00080AFA
			public unsafe static Action<GameObject> __9__4_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_DecorationSatoriEye.__c.NativeFieldInfoPtr___9__4_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_DecorationSatoriEye.__c.NativeFieldInfoPtr___9__4_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009AE7 RID: 39655
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009AE8 RID: 39656
			private static readonly IntPtr NativeFieldInfoPtr___9__4_2;

			// Token: 0x04009AE9 RID: 39657
			private static readonly IntPtr NativeFieldInfoPtr___9__4_6;

			// Token: 0x04009AEA RID: 39658
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AEB RID: 39659
			private static readonly IntPtr NativeMethodInfoPtr__DecorationBuffEnterNight_b__4_2_Internal_String_String_0;

			// Token: 0x04009AEC RID: 39660
			private static readonly IntPtr NativeMethodInfoPtr__DecorationBuffEnterNight_b__4_6_Internal_Void_GameObject_0;
		}

		// Token: 0x02000D33 RID: 3379
		[ObfuscatedName("GameData.Profile.DLC2_DecorationSatoriEye+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F339 RID: 62265 RVA: 0x003997D4 File Offset: 0x003979D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_DecorationSatoriEye>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass5_0>.NativeClassPtr);
				DLC2_DecorationSatoriEye.__c__DisplayClass5_0.NativeFieldInfoPtr_guestGroupController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass5_0>.NativeClassPtr, "guestGroupController");
				DLC2_DecorationSatoriEye.__c__DisplayClass5_0.NativeFieldInfoPtr_remainingMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass5_0>.NativeClassPtr, "remainingMoney");
				DLC2_DecorationSatoriEye.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass5_0>.NativeClassPtr, 100682520);
				DLC2_DecorationSatoriEye.__c__DisplayClass5_0.NativeMethodInfoPtr__SetNum_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass5_0>.NativeClassPtr, 100682521);
			}

			// Token: 0x0600F33A RID: 62266 RVA: 0x00399850 File Offset: 0x00397A50
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_DecorationSatoriEye.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F33B RID: 62267 RVA: 0x0039988C File Offset: 0x00397A8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233104, XrefRangeEnd = 233119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetNum_b__0(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_DecorationSatoriEye.__c__DisplayClass5_0.NativeMethodInfoPtr__SetNum_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F33C RID: 62268 RVA: 0x0008290C File Offset: 0x00080B0C
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F13 RID: 20243
			// (get) Token: 0x0600F33D RID: 62269 RVA: 0x003998D0 File Offset: 0x00397AD0
			// (set) Token: 0x0600F33E RID: 62270 RVA: 0x00082915 File Offset: 0x00080B15
			public unsafe GuestGroupController guestGroupController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass5_0.NativeFieldInfoPtr_guestGroupController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass5_0.NativeFieldInfoPtr_guestGroupController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F14 RID: 20244
			// (get) Token: 0x0600F33F RID: 62271 RVA: 0x00399900 File Offset: 0x00397B00
			// (set) Token: 0x0600F340 RID: 62272 RVA: 0x00082934 File Offset: 0x00080B34
			public unsafe int remainingMoney
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass5_0.NativeFieldInfoPtr_remainingMoney);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_DecorationSatoriEye.__c__DisplayClass5_0.NativeFieldInfoPtr_remainingMoney)) = value;
				}
			}

			// Token: 0x04009AED RID: 39661
			private static readonly IntPtr NativeFieldInfoPtr_guestGroupController;

			// Token: 0x04009AEE RID: 39662
			private static readonly IntPtr NativeFieldInfoPtr_remainingMoney;

			// Token: 0x04009AEF RID: 39663
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AF0 RID: 39664
			private static readonly IntPtr NativeMethodInfoPtr__SetNum_b__0_Internal_Void_TextMeshProUGUI_0;
		}
	}
}
