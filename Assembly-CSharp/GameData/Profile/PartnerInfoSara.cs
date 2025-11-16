using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;
using NightScene.EventUtility;
using NightScene.PartnerUtility;

namespace GameData.Profile
{
	// Token: 0x02000329 RID: 809
	public class PartnerInfoSara : PartnerInfo
	{
		// Token: 0x06005F65 RID: 24421 RVA: 0x001DC000 File Offset: 0x001DA200
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoSara()
		{
			Il2CppClassPointerStore<PartnerInfoSara>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoSara");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoSara>.NativeClassPtr);
			PartnerInfoSara.NativeFieldInfoPtr_spawnGuestInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSara>.NativeClassPtr, "spawnGuestInterval");
			PartnerInfoSara.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSara>.NativeClassPtr, 100682884);
			PartnerInfoSara.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSara>.NativeClassPtr, 100682885);
			PartnerInfoSara.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSara>.NativeClassPtr, 100682886);
		}

		// Token: 0x06005F66 RID: 24422 RVA: 0x001DC080 File Offset: 0x001DA280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235547, XrefRangeEnd = 235570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, Il2CppReferenceArray<Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoSara.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F67 RID: 24423 RVA: 0x001DC104 File Offset: 0x001DA304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235570, XrefRangeEnd = 235573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerInfoSara.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F68 RID: 24424 RVA: 0x001DC154 File Offset: 0x001DA354
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoSara() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoSara>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSara.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F69 RID: 24425 RVA: 0x00033F16 File Offset: 0x00032116
		public PartnerInfoSara(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020FA RID: 8442
		// (get) Token: 0x06005F6A RID: 24426 RVA: 0x001DC190 File Offset: 0x001DA390
		// (set) Token: 0x06005F6B RID: 24427 RVA: 0x00033F1F File Offset: 0x0003211F
		public unsafe int spawnGuestInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSara.NativeFieldInfoPtr_spawnGuestInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSara.NativeFieldInfoPtr_spawnGuestInterval)) = value;
			}
		}

		// Token: 0x04003F17 RID: 16151
		private static readonly IntPtr NativeFieldInfoPtr_spawnGuestInterval;

		// Token: 0x04003F18 RID: 16152
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003F19 RID: 16153
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003F1A RID: 16154
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D59 RID: 3417
		[ObfuscatedName("GameData.Profile.PartnerInfoSara+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600F4C7 RID: 62663 RVA: 0x0039DC10 File Offset: 0x0039BE10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<PartnerInfoSara.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoSara>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoSara.__c__DisplayClass1_0>.NativeClassPtr);
				PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSara.__c__DisplayClass1_0>.NativeClassPtr, "eventManager");
				PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr_salmonBuffInterruptCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSara.__c__DisplayClass1_0>.NativeClassPtr, "salmonBuffInterruptCallback");
				PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr_removeCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSara.__c__DisplayClass1_0>.NativeClassPtr, "removeCallback");
				PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSara.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr_salmonEffectInterruptCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSara.__c__DisplayClass1_0>.NativeClassPtr, "salmonEffectInterruptCallback");
				PartnerInfoSara.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSara.__c__DisplayClass1_0>.NativeClassPtr, 100682887);
				PartnerInfoSara.__c__DisplayClass1_0.NativeMethodInfoPtr__OnPartnerLoad_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSara.__c__DisplayClass1_0>.NativeClassPtr, 100682888);
				PartnerInfoSara.__c__DisplayClass1_0.NativeMethodInfoPtr__OnPartnerLoad_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSara.__c__DisplayClass1_0>.NativeClassPtr, 100682889);
				PartnerInfoSara.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSara.__c__DisplayClass1_0>.NativeClassPtr, 100682890);
			}

			// Token: 0x0600F4C8 RID: 62664 RVA: 0x0039DCF0 File Offset: 0x0039BEF0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoSara.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSara.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4C9 RID: 62665 RVA: 0x0039DD2C File Offset: 0x0039BF2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235495, XrefRangeEnd = 235535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPartnerLoad_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSara.__c__DisplayClass1_0.NativeMethodInfoPtr__OnPartnerLoad_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4CA RID: 62666 RVA: 0x0039DD60 File Offset: 0x0039BF60
			[CallerCount(0)]
			public unsafe void _OnPartnerLoad_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSara.__c__DisplayClass1_0.NativeMethodInfoPtr__OnPartnerLoad_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4CB RID: 62667 RVA: 0x0039DD94 File Offset: 0x0039BF94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235535, XrefRangeEnd = 235547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSara.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4CC RID: 62668 RVA: 0x00083741 File Offset: 0x00081941
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F92 RID: 20370
			// (get) Token: 0x0600F4CD RID: 62669 RVA: 0x0039DDC8 File Offset: 0x0039BFC8
			// (set) Token: 0x0600F4CE RID: 62670 RVA: 0x0008374A File Offset: 0x0008194A
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F93 RID: 20371
			// (get) Token: 0x0600F4CF RID: 62671 RVA: 0x0039DDF8 File Offset: 0x0039BFF8
			// (set) Token: 0x0600F4D0 RID: 62672 RVA: 0x00083769 File Offset: 0x00081969
			public unsafe Action salmonBuffInterruptCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr_salmonBuffInterruptCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr_salmonBuffInterruptCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F94 RID: 20372
			// (get) Token: 0x0600F4D1 RID: 62673 RVA: 0x0039DE28 File Offset: 0x0039C028
			// (set) Token: 0x0600F4D2 RID: 62674 RVA: 0x00083788 File Offset: 0x00081988
			public unsafe Action removeCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr_removeCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr_removeCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F95 RID: 20373
			// (get) Token: 0x0600F4D3 RID: 62675 RVA: 0x0039DE58 File Offset: 0x0039C058
			// (set) Token: 0x0600F4D4 RID: 62676 RVA: 0x000837A7 File Offset: 0x000819A7
			public unsafe PartnerInfoSara __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoSara>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F96 RID: 20374
			// (get) Token: 0x0600F4D5 RID: 62677 RVA: 0x0039DE88 File Offset: 0x0039C088
			// (set) Token: 0x0600F4D6 RID: 62678 RVA: 0x000837C6 File Offset: 0x000819C6
			public unsafe Action salmonEffectInterruptCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr_salmonEffectInterruptCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoSara.__c__DisplayClass1_0.NativeFieldInfoPtr_salmonEffectInterruptCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BEA RID: 39914
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009BEB RID: 39915
			private static readonly IntPtr NativeFieldInfoPtr_salmonBuffInterruptCallback;

			// Token: 0x04009BEC RID: 39916
			private static readonly IntPtr NativeFieldInfoPtr_removeCallback;

			// Token: 0x04009BED RID: 39917
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009BEE RID: 39918
			private static readonly IntPtr NativeFieldInfoPtr_salmonEffectInterruptCallback;

			// Token: 0x04009BEF RID: 39919
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BF0 RID: 39920
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__0_Internal_Void_0;

			// Token: 0x04009BF1 RID: 39921
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__1_Internal_Void_0;

			// Token: 0x04009BF2 RID: 39922
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000D5A RID: 3418
		[ObfuscatedName("GameData.Profile.PartnerInfoSara+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600F4D7 RID: 62679 RVA: 0x0039DEB8 File Offset: 0x0039C0B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PartnerInfoSara.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerInfoSara>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoSara.__c>.NativeClassPtr);
				PartnerInfoSara.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSara.__c>.NativeClassPtr, "<>9");
				PartnerInfoSara.__c.NativeFieldInfoPtr___9__1_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoSara.__c>.NativeClassPtr, "<>9__1_3");
				PartnerInfoSara.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSara.__c>.NativeClassPtr, 100682892);
				PartnerInfoSara.__c.NativeMethodInfoPtr__OnPartnerLoad_b__1_3_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoSara.__c>.NativeClassPtr, 100682893);
			}

			// Token: 0x0600F4D8 RID: 62680 RVA: 0x0039DF34 File Offset: 0x0039C134
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoSara.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSara.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F4D9 RID: 62681 RVA: 0x0039DF70 File Offset: 0x0039C170
			[CallerCount(0)]
			public unsafe string _OnPartnerLoad_b__1_3(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoSara.__c.NativeMethodInfoPtr__OnPartnerLoad_b__1_3_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F4DA RID: 62682 RVA: 0x000837E5 File Offset: 0x000819E5
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F97 RID: 20375
			// (get) Token: 0x0600F4DB RID: 62683 RVA: 0x0039DFB8 File Offset: 0x0039C1B8
			// (set) Token: 0x0600F4DC RID: 62684 RVA: 0x000837EE File Offset: 0x000819EE
			public unsafe static PartnerInfoSara.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerInfoSara.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerInfoSara.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerInfoSara.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F98 RID: 20376
			// (get) Token: 0x0600F4DD RID: 62685 RVA: 0x0039DFE0 File Offset: 0x0039C1E0
			// (set) Token: 0x0600F4DE RID: 62686 RVA: 0x00083800 File Offset: 0x00081A00
			public unsafe static Func<string, string> __9__1_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerInfoSara.__c.NativeFieldInfoPtr___9__1_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerInfoSara.__c.NativeFieldInfoPtr___9__1_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009BF3 RID: 39923
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009BF4 RID: 39924
			private static readonly IntPtr NativeFieldInfoPtr___9__1_3;

			// Token: 0x04009BF5 RID: 39925
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009BF6 RID: 39926
			private static readonly IntPtr NativeMethodInfoPtr__OnPartnerLoad_b__1_3_Internal_String_String_0;
		}
	}
}
