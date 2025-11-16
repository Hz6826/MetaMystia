using System;
using Common.UI;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MainScene.UI;
using UnityEngine;
using UnityEngine.UI;

namespace MainScene
{
	// Token: 0x020000AF RID: 175
	public class SceneManager : MonoSingleton<SceneManager>
	{
		// Token: 0x060012D1 RID: 4817 RVA: 0x000DDAA0 File Offset: 0x000DBCA0
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManager()
		{
			Il2CppClassPointerStore<SceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MainScene", "SceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager>.NativeClassPtr);
			SceneManager.NativeFieldInfoPtr_bgm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "bgm");
			SceneManager.NativeFieldInfoPtr_MainPanelParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "MainPanelParent");
			SceneManager.NativeFieldInfoPtr_PannelRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "PannelRoot");
			SceneManager.NativeFieldInfoPtr_DLCElementRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "DLCElementRoot");
			SceneManager.NativeFieldInfoPtr_m_TitleSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_TitleSprite");
			SceneManager.NativeFieldInfoPtr_m_TitleImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "m_TitleImage");
			SceneManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666552);
			SceneManager.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666553);
			SceneManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666554);
			SceneManager.NativeMethodInfoPtr_GotoDayScene_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666555);
			SceneManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666556);
			SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100666557);
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x000DDBC0 File Offset: 0x000DBDC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52244, XrefRangeEnd = 52342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D3 RID: 4819 RVA: 0x000DDBFC File Offset: 0x000DBDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52342, XrefRangeEnd = 52351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x000DDC30 File Offset: 0x000DBE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52351, XrefRangeEnd = 52354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInstanceDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManager.NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000DDC6C File Offset: 0x000DBE6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 52371, RefRangeEnd = 52373, XrefRangeStart = 52354, XrefRangeEnd = 52371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GotoDayScene(Action loadAction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loadAction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GotoDayScene_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x000DDCB0 File Offset: 0x000DBEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52373, XrefRangeEnd = 52378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x000DDCEC File Offset: 0x000DBEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52378, XrefRangeEnd = 52381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0000BF51 File Offset: 0x0000A151
		public SceneManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x000DDD28 File Offset: 0x000DBF28
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x0000BF5A File Offset: 0x0000A15A
		public unsafe LoopedBGMPackage bgm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_bgm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_bgm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x000DDD58 File Offset: 0x000DBF58
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x0000BF79 File Offset: 0x0000A179
		public unsafe MainMenuPannel MainPanelParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_MainPanelParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_MainPanelParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x000DDD88 File Offset: 0x000DBF88
		// (set) Token: 0x060012DE RID: 4830 RVA: 0x0000BF98 File Offset: 0x0000A198
		public unsafe RectTransform PannelRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_PannelRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_PannelRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060012DF RID: 4831 RVA: 0x000DDDB8 File Offset: 0x000DBFB8
		// (set) Token: 0x060012E0 RID: 4832 RVA: 0x0000BFB7 File Offset: 0x0000A1B7
		public unsafe RectTransform DLCElementRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_DLCElementRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_DLCElementRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x000DDDE8 File Offset: 0x000DBFE8
		// (set) Token: 0x060012E2 RID: 4834 RVA: 0x0000BFD6 File Offset: 0x0000A1D6
		public MultiLanguageSprite m_TitleSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_TitleSprite);
				return new MultiLanguageSprite(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_TitleSprite), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MultiLanguageSprite>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060012E3 RID: 4835 RVA: 0x000DDE18 File Offset: 0x000DC018
		// (set) Token: 0x060012E4 RID: 4836 RVA: 0x0000C004 File Offset: 0x0000A204
		public unsafe Image m_TitleImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_TitleImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_m_TitleImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CBA RID: 3258
		private static readonly IntPtr NativeFieldInfoPtr_bgm;

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeFieldInfoPtr_MainPanelParent;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeFieldInfoPtr_PannelRoot;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeFieldInfoPtr_DLCElementRoot;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeFieldInfoPtr_m_TitleSprite;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeFieldInfoPtr_m_TitleImage;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_OnInstanceDestroyed_Protected_Virtual_Void_0;

		// Token: 0x04000CC3 RID: 3267
		private static readonly IntPtr NativeMethodInfoPtr_GotoDayScene_Public_Void_Action_0;

		// Token: 0x04000CC4 RID: 3268
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04000CC5 RID: 3269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005C1 RID: 1473
		[ObfuscatedName("MainScene.SceneManager+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008CC1 RID: 36033 RVA: 0x0026A5FC File Offset: 0x002687FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr);
				SceneManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, "<>9");
				SceneManager.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, "<>9__6_0");
				SceneManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, 100666559);
				SceneManager.__c.NativeMethodInfoPtr__Awake_b__6_0_Internal_Boolean_KeyValuePair_2_String_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr, 100666560);
			}

			// Token: 0x06008CC2 RID: 36034 RVA: 0x0026A678 File Offset: 0x00268878
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CC3 RID: 36035 RVA: 0x0026A6B4 File Offset: 0x002688B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52157, XrefRangeEnd = 52170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Awake_b__6_0(KeyValuePair<string, GameObject> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c.NativeMethodInfoPtr__Awake_b__6_0_Internal_Boolean_KeyValuePair_2_String_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008CC4 RID: 36036 RVA: 0x0004BB02 File Offset: 0x00049D02
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F17 RID: 12055
			// (get) Token: 0x06008CC5 RID: 36037 RVA: 0x0026A708 File Offset: 0x00268908
			// (set) Token: 0x06008CC6 RID: 36038 RVA: 0x0004BB0B File Offset: 0x00049D0B
			public unsafe static SceneManager.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F18 RID: 12056
			// (get) Token: 0x06008CC7 RID: 36039 RVA: 0x0026A730 File Offset: 0x00268930
			// (set) Token: 0x06008CC8 RID: 36040 RVA: 0x0004BB1D File Offset: 0x00049D1D
			public unsafe static Func<KeyValuePair<string, GameObject>, bool> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SceneManager.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, GameObject>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SceneManager.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C0D RID: 23565
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005C0E RID: 23566
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04005C0F RID: 23567
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C10 RID: 23568
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__6_0_Internal_Boolean_KeyValuePair_2_String_GameObject_0;
		}

		// Token: 0x020005C2 RID: 1474
		[ObfuscatedName("MainScene.SceneManager+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x06008CC9 RID: 36041 RVA: 0x0026A758 File Offset: 0x00268958
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<SceneManager.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager.__c__DisplayClass9_0>.NativeClassPtr);
				SceneManager.__c__DisplayClass9_0.NativeFieldInfoPtr_loadAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager.__c__DisplayClass9_0>.NativeClassPtr, "loadAction");
				SceneManager.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass9_0>.NativeClassPtr, 100666561);
				SceneManager.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager.__c__DisplayClass9_0>.NativeClassPtr, 100666562);
			}

			// Token: 0x06008CCA RID: 36042 RVA: 0x0026A7C0 File Offset: 0x002689C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CCB RID: 36043 RVA: 0x0026A7FC File Offset: 0x002689FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52170, XrefRangeEnd = 52244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CCC RID: 36044 RVA: 0x0004BB2F File Offset: 0x00049D2F
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F19 RID: 12057
			// (get) Token: 0x06008CCD RID: 36045 RVA: 0x0026A830 File Offset: 0x00268A30
			// (set) Token: 0x06008CCE RID: 36046 RVA: 0x0004BB38 File Offset: 0x00049D38
			public unsafe Action loadAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass9_0.NativeFieldInfoPtr_loadAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.__c__DisplayClass9_0.NativeFieldInfoPtr_loadAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C11 RID: 23569
			private static readonly IntPtr NativeFieldInfoPtr_loadAction;

			// Token: 0x04005C12 RID: 23570
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C13 RID: 23571
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}
	}
}
