using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using ResultScene.UI;
using UnityEngine;

namespace ResultScene
{
	// Token: 0x02000038 RID: 56
	public class SceneManager : MonoBehaviour
	{
		// Token: 0x060005F1 RID: 1521 RVA: 0x000B1564 File Offset: 0x000AF764
		// Note: this type is marked as 'beforefieldinit'.
		static SceneManager()
		{
			Il2CppClassPointerStore<SceneManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ResultScene", "SceneManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager>.NativeClassPtr);
			SceneManager.NativeFieldInfoPtr_overrideDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "overrideDay");
			SceneManager.NativeFieldInfoPtr_additiveDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "additiveDay");
			SceneManager.NativeFieldInfoPtr_activePannelRoot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "activePannelRoot");
			SceneManager.NativeFieldInfoPtr_ResultSceneStatusPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "ResultSceneStatusPannel");
			SceneManager.NativeFieldInfoPtr_ResultSceneSavePannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "ResultSceneSavePannel");
			SceneManager.NativeFieldInfoPtr_bgm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "bgm");
			SceneManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664159);
			SceneManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664160);
			SceneManager.NativeMethodInfoPtr_StartAsync_Private_UniTaskVoid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664161);
			SceneManager.NativeMethodInfoPtr_GotoLoadScene_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664162);
			SceneManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664163);
			SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, 100664164);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000B1684 File Offset: 0x000AF884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26403, XrefRangeEnd = 26409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000B16B8 File Offset: 0x000AF8B8
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000B16EC File Offset: 0x000AF8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26409, XrefRangeEnd = 26414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid StartAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_StartAsync_Private_UniTaskVoid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000B1728 File Offset: 0x000AF928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26414, XrefRangeEnd = 26434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GotoLoadScene()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr_GotoLoadScene_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000B1750 File Offset: 0x000AF950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 26434, XrefRangeEnd = 26438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SceneManager.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x000B178C File Offset: 0x000AF98C
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SceneManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000056FA File Offset: 0x000038FA
		public SceneManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x000B17C8 File Offset: 0x000AF9C8
		// (set) Token: 0x060005FA RID: 1530 RVA: 0x00005703 File Offset: 0x00003903
		public unsafe static Nullable<int> overrideDay
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_overrideDay, intPtr);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_overrideDay, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x000B1804 File Offset: 0x000AFA04
		// (set) Token: 0x060005FC RID: 1532 RVA: 0x0000571A File Offset: 0x0000391A
		public unsafe static Nullable<int> additiveDay
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(SceneManager.NativeFieldInfoPtr_additiveDay, intPtr);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SceneManager.NativeFieldInfoPtr_additiveDay, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x000B1840 File Offset: 0x000AFA40
		// (set) Token: 0x060005FE RID: 1534 RVA: 0x00005731 File Offset: 0x00003931
		public unsafe RectTransform activePannelRoot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_activePannelRoot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_activePannelRoot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x000B1870 File Offset: 0x000AFA70
		// (set) Token: 0x06000600 RID: 1536 RVA: 0x00005750 File Offset: 0x00003950
		public unsafe ResultSceneStatusPannel ResultSceneStatusPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_ResultSceneStatusPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneStatusPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_ResultSceneStatusPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x000B18A0 File Offset: 0x000AFAA0
		// (set) Token: 0x06000602 RID: 1538 RVA: 0x0000576F File Offset: 0x0000396F
		public unsafe ResultSceneSavePannel ResultSceneSavePannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_ResultSceneSavePannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResultSceneSavePannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager.NativeFieldInfoPtr_ResultSceneSavePannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x000B18D0 File Offset: 0x000AFAD0
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x0000578E File Offset: 0x0000398E
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

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_overrideDay;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_additiveDay;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_activePannelRoot;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_ResultSceneStatusPannel;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_ResultSceneSavePannel;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_bgm;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_StartAsync_Private_UniTaskVoid_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_GotoLoadScene_Private_Static_Void_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020004C6 RID: 1222
		[ObfuscatedName("ResultScene.SceneManager+<StartAsync>d__8")]
		public sealed class _StartAsync_d__8 : ValueType
		{
			// Token: 0x06008044 RID: 32836 RVA: 0x00245824 File Offset: 0x00243A24
			// Note: this type is marked as 'beforefieldinit'.
			static _StartAsync_d__8()
			{
				Il2CppClassPointerStore<SceneManager._StartAsync_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SceneManager>.NativeClassPtr, "<StartAsync>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneManager._StartAsync_d__8>.NativeClassPtr);
				SceneManager._StartAsync_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._StartAsync_d__8>.NativeClassPtr, "<>1__state");
				SceneManager._StartAsync_d__8.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._StartAsync_d__8>.NativeClassPtr, "<>t__builder");
				SceneManager._StartAsync_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._StartAsync_d__8>.NativeClassPtr, "<>4__this");
				SceneManager._StartAsync_d__8.NativeFieldInfoPtr__task_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._StartAsync_d__8>.NativeClassPtr, "<task>5__2");
				SceneManager._StartAsync_d__8.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._StartAsync_d__8>.NativeClassPtr, "<>u__1");
				SceneManager._StartAsync_d__8.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._StartAsync_d__8>.NativeClassPtr, "<>u__2");
				SceneManager._StartAsync_d__8.NativeFieldInfoPtr___u__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneManager._StartAsync_d__8>.NativeClassPtr, "<>u__3");
				SceneManager._StartAsync_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._StartAsync_d__8>.NativeClassPtr, 100664165);
				SceneManager._StartAsync_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneManager._StartAsync_d__8>.NativeClassPtr, 100664166);
			}

			// Token: 0x06008045 RID: 32837 RVA: 0x00245904 File Offset: 0x00243B04
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 26401, RefRangeEnd = 26403, XrefRangeStart = 26300, XrefRangeEnd = 26401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._StartAsync_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008046 RID: 32838 RVA: 0x0024593C File Offset: 0x00243B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneManager._StartAsync_d__8.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008047 RID: 32839 RVA: 0x00045350 File Offset: 0x00043550
			public _StartAsync_d__8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008048 RID: 32840 RVA: 0x00045359 File Offset: 0x00043559
			public _StartAsync_d__8() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneManager._StartAsync_d__8>.NativeClassPtr))
			{
			}

			// Token: 0x17002B4A RID: 11082
			// (get) Token: 0x06008049 RID: 32841 RVA: 0x00245984 File Offset: 0x00243B84
			// (set) Token: 0x0600804A RID: 32842 RVA: 0x0004536B File Offset: 0x0004356B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002B4B RID: 11083
			// (get) Token: 0x0600804B RID: 32843 RVA: 0x002459AC File Offset: 0x00243BAC
			// (set) Token: 0x0600804C RID: 32844 RVA: 0x00045386 File Offset: 0x00043586
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B4C RID: 11084
			// (get) Token: 0x0600804D RID: 32845 RVA: 0x002459DC File Offset: 0x00243BDC
			// (set) Token: 0x0600804E RID: 32846 RVA: 0x000453B4 File Offset: 0x000435B4
			public unsafe SceneManager __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002B4D RID: 11085
			// (get) Token: 0x0600804F RID: 32847 RVA: 0x00245A0C File Offset: 0x00243C0C
			// (set) Token: 0x06008050 RID: 32848 RVA: 0x000453D3 File Offset: 0x000435D3
			public UniTask _task_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr__task_5__2);
					return new UniTask(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr__task_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B4E RID: 11086
			// (get) Token: 0x06008051 RID: 32849 RVA: 0x00245A3C File Offset: 0x00243C3C
			// (set) Token: 0x06008052 RID: 32850 RVA: 0x00045401 File Offset: 0x00043601
			public UniTask<ResultSceneStatusPannel>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr___u__1);
					return new UniTask<ResultSceneStatusPannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<ResultSceneStatusPannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<ResultSceneStatusPannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B4F RID: 11087
			// (get) Token: 0x06008053 RID: 32851 RVA: 0x00245A6C File Offset: 0x00243C6C
			// (set) Token: 0x06008054 RID: 32852 RVA: 0x0004542F File Offset: 0x0004362F
			public UniTask<ResultSceneSavePannel>.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr___u__2);
					return new UniTask<ResultSceneSavePannel>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<ResultSceneSavePannel>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<ResultSceneSavePannel>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002B50 RID: 11088
			// (get) Token: 0x06008055 RID: 32853 RVA: 0x00245A9C File Offset: 0x00243C9C
			// (set) Token: 0x06008056 RID: 32854 RVA: 0x0004545D File Offset: 0x0004365D
			public UniTask.Awaiter __u__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr___u__3);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneManager._StartAsync_d__8.NativeFieldInfoPtr___u__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400542D RID: 21549
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400542E RID: 21550
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400542F RID: 21551
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005430 RID: 21552
			private static readonly IntPtr NativeFieldInfoPtr__task_5__2;

			// Token: 0x04005431 RID: 21553
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005432 RID: 21554
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x04005433 RID: 21555
			private static readonly IntPtr NativeFieldInfoPtr___u__3;

			// Token: 0x04005434 RID: 21556
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005435 RID: 21557
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
